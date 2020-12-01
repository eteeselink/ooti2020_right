using System;
using Spectre.Console;
namespace Kiosk
{

    

    public class BasicResult {
        public BasicResult(){

        }
     
        public void showBasicResults(SingleChoiceAnswer answer) {
            int yes=0;
            int no = 0;
            int qNom = 0;
           //Array is needed for response    
               if(answer.Response==true ){
               yes++;
               }
               else{ 
               no++;
               }
             Console.WriteLine("Question is:  {0}", answer.Question);
             Console.WriteLine("Yes count is:  {0}", yes);
             Console.WriteLine("No count is:  {0}", no);
             Console.WriteLine("Want to see the detailed results? enter Y");
             string a =Console.ReadLine();
             if(a =="y"){
                 new DetailedResult().show();
             }
        }
    }
}