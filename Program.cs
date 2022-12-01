internal class Program
{
    private static void Main(string[] args)
    {

        Ogrenci ogrenci=new Ogrenci();
        ogrenci.Isim="Ayşe";
        ogrenci.Soyisim="Yılmaz";
        ogrenci.OgernciNo=56;
        ogrenci.Sinif=4;
        ogrenci.OgrenciBilgileriniGetir();
        
        Console.WriteLine("**********************");
        ogrenci.SinifAtlat();
        ogrenci.OgrenciBilgileriniGetir();

         Console.WriteLine("**********************");
         Ogrenci ogrecnci2=new Ogrenci(){Isim="hakkı",Soyisim="soysal",OgernciNo=5,Sinif=1};
         ogrecnci2.SınıfDusur();
         ogrecnci2.OgrenciBilgileriniGetir();


     
    }
   
}

 class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogernciNo;
        private int sinif;


        public string Isim
        {
            get{return isim;}
            set{isim =value;}
        }

        public string Soyisim{get;set;}
        public int OgernciNo{get;set;}
        public int Sinif{
            get =>sinif;
            set
            {
                if(value<1)
                {
                    Console.WriteLine("Sınıf en az bir olabilir.");
                    sinif=1;
                }
                else
                sinif=value;
            }
        }

        public Ogrenci(string isim,string soyisim,int ogernciNo,int sinif)
        {
            Isim=isim;
            Soyisim=soyisim;
            OgernciNo=ogernciNo;
            Sinif=sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {

            Console.WriteLine("Öğrenci Adı:{0}",this.Isim);
            Console.WriteLine("Öğrenci SoyAdı:{0}",this.Soyisim);
            Console.WriteLine("Öğrenci No:{0}",this.OgernciNo);
            Console.WriteLine("Öğrenci Sınıfı:{0}",this.Sinif);
        }

        public void SinifAtlat()
        {

            this.Sinif=this.Sinif+1;

        }
        public void SınıfDusur()
        {

            this.Sinif=this.Sinif-1;
        }

        
    }