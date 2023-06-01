using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universite_Arsiv_Uygulamasi.DOMAİN;


namespace Universite_Arsiv_Uygulamasi.DAL
{
    internal class KullaniciDAO
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public void kullaniciOlustur(Kullanici gKullanici)
        {
            (new MySqlCommand("insert into Kullanici (username,password,userType,status) values ('" + gKullanici.Username + "','" + gKullanici.Password + "','" + gKullanici.UserType + "'," + gKullanici.Status + ")", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        public bool kullaniciKontrol(String gKullaniciAdi,String gSifre)
        {
            con = new dbBaglanti().baglantiGetir();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kullanici where username='" + gKullaniciAdi + "' AND password='" + gSifre + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool adminKontrol(String gKullaniciAdi, String gSifre)
        {
            con = new dbBaglanti().baglantiGetir();
            cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Kullanici where userId= '1' AND username='" + gKullaniciAdi + "' AND password='" + gSifre + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal System.Collections.ArrayList kullanicilariListele()
        {
            ArrayList kayitliKullanicilar = new ArrayList();
            //MySqlCommand komutum=new MySqlCommand("select * from bolum", (new dbBaglanti()).baglantiGetir())
            MySqlDataReader kayitliKullanici = (new MySqlCommand("select * from Kullanıcı", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (kayitliKullanici.Read())
            {
                kayitliKullanicilar.Add(new Kullanici(gUserName: Convert.ToString(kayitliKullanicilar[0]), gPassword: Convert.ToString(kayitliKullanicilar[1]), gUserType: Convert.ToString(kayitliKullanicilar[3])));
            }
            return kayitliKullanicilar;
        }
    }
}
