//1)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
//2)Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
//3)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
//4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

// n=sayi[0]   m=sayi[1]
// 


using System;
namespace Algorithms
{
    class Soru1
    {  
        static void Main(string[] args)
        {     
            // Soru 1
            int n;
              Console.WriteLine("Lütfen sayı miktarını giriniz:");
        
            n = Convert.ToInt16(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < sayilar.Length; i++)
  {
            Console.Write("Klavyeden {0}. sayıyı girin:", i+1);
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
    
  }
           for(int i=0;i<n;i++){                                // Klavyeden 5 .
                if(sayilar[i]%2==0){
                    Console.WriteLine(sayilar[i]);
                }
           } 
        
        // Soru 2
        int[] sayi=new int[2];
            for(int i=0;i<2;i++){
                Console.Write("Klavyeden {0}. sayıyı girin:", i+1);
                sayi[i] = Convert.ToInt32(Console.ReadLine());
            }
             int a=sayi[0];
             int [] rakam=new int[a];
             Console.WriteLine("Klavyeden"+sayi[0]+"adet sayı girin.");
             for(int i=0;i<rakam.Length;i++){
                Console.WriteLine("Klavyeden" + " "+ (i+1)+". sayı girin.");
                rakam[i]=Convert.ToInt32(Console.ReadLine());
            }
               for(int i=0;i<rakam.Length;i++){
                if(rakam[i]%sayi[1]==0 || rakam[i]==sayi[1]){
                    Console.WriteLine(rakam[i]);
                }
               }
              // Soru 3
                int b;
                Console.WriteLine("Lütfen kelime miktarını giriniz:");
                b=Convert.ToInt16(Console.ReadLine());
                  string[] kelimeler=new string[b];
                       
                        for(int i=0;i<b;i++){
                            kelimeler[i]+=Console.ReadLine();
                        
                        }
                       for(int i=b-1;i>=0;i--){
                        Console.WriteLine(kelimeler[i]);
                       }
                     
                     // Soru 4
                     string cumle="";
                     Console.WriteLine("Lütfen bir cümle girin.");
                     cumle+=Console.ReadLine();
                     
                   string[] toplamkelime = cumle.Split(" ");
            Console.WriteLine("Toplam kelime sayısı :"+toplamkelime.Length);
                string[] toplamharf=cumle.Split(" ");
                Console.WriteLine(cumle.Length-(toplamkelime.Length-1));
                
                
                    
                       
                  
               }
            }   
        }
    
    
    
    
     
