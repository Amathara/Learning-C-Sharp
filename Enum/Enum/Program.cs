using System.ComponentModel.Design;
using System.Diagnostics;

namespace Enum1
{
    //Definer en enum for fag:
    enum StudySubject
    {
        Billedkunst,
        Biologi,
        Matematik,
        Musik,
        Psykologi

    }
    class Program
    {
        // Lav til en metode ved at adde:
        static void PrintStudySubjectMessage(StudySubject currentStudySubject)
        {
            // Sammenligning med enum values - Her siger vi hvad der skal ske når vi kalder fx. "currentStudySubject = StudySubject.Billedkunst" 
             
            if (currentStudySubject == StudySubject.Billedkunst)
            {
                Console.WriteLine("Frem med malingen!");
            }
            else if (currentStudySubject == StudySubject.Biologi)
            {
                Console.WriteLine("Nu skal vi lære om en celle 8-)");
            }
            else if (currentStudySubject == StudySubject.Matematik)
            {
                Console.WriteLine("Tid til at finde formelsamlingen");
            }
            else if (currentStudySubject == StudySubject.Musik)
            {
                Console.WriteLine("Er du på guitaren eller trianglen i dag?");
            }
            else if (currentStudySubject == StudySubject.Psykologi)
            {
                Console.WriteLine("Nu dykker vi ind i menneskers PSYKE...\nPlz sig vi ikke skal se 'Er du mors lille dreng' i dag :'(");

            }
            else
            {
                Console.WriteLine("Hey, du! Vælg et fag fra listen!");
            }
        }
        static void Main()
        {
            // Brug enum:
            StudySubject currentStudySubject = StudySubject.Billedkunst;


            // Sammenligning med enum values - Her siger vi hvad der skal ske når vi kalder fx. "currentStudySubject = StudySubject.Billedkunst" 
            // Lav til en metode ved at adde: 
       
           
          /*  // Konversion fra Enum til integer:
            int subjectNumber = (int)currentStudySubject; // 0 for Billedkunst
            Console.WriteLine($"Nummer på fag: {subjectNumber}");

            //Koversion fra int til Enum:
            StudySubject convertedSubject = (StudySubject)2; // Matematik
            Console.WriteLine($"Converted Subject: {convertedSubject}");

            // Få værdier fra et Enum:
             foreach (StudySubject studySubject in Enum.GetValues(typeof(StudySubject)))
             {
                 Console.WriteLine(studySubject);
             }
            */

           
            // Menu til at kalde "metoder"

            bool running = true; 

           
           
            while (running)
                        {

                         
                            Console.WriteLine("Hvilket fag skal du have i dag? \n " +
                            "\n 1. Billedkunst\n " +
                            "\n 2. Biologi!\n " +
                            "\n 3. Matematik \n " +
                            "\n 4. Musik\n " +
                            "\n 5. Psykologi \n " +
                            "\n 6. Jeg har fri nu! \n");


                            int valg = int.Parse(Console.ReadLine());

                            switch (valg)
                            {
                                case 1:
                    
                        currentStudySubject = StudySubject.Billedkunst;

                        
                                    break;
                                case 2:
                        currentStudySubject = StudySubject.Biologi ;
             
                                    break;
                                case 3:

                        currentStudySubject = StudySubject.Matematik ;
             
                                    break;

                                case 4:

                        currentStudySubject = StudySubject.Musik ;
             
                                    break;
                                case 5:
                        currentStudySubject = StudySubject.Psykologi;
                                    
             
                                    break;
                                

                                case 6:
                                    Console.WriteLine("\nNå okay!\nJamen så tag dog hjem.");
                                    running = false;
                                    break;

                            }

                // Dette er hvad der sker under hvert svar:

                if (running) // Indsæt streg inden svaret kommer ud:
                {
                    Console.WriteLine("\n-------------------------------\n");
                }
                // Kald the method til at printe besked:
                if (running) // Only call it if we're not exiting
                {
                    PrintStudySubjectMessage(currentStudySubject);
                }
                if (running) // Spørg om andre fag + streg
                {
                    Console.WriteLine("\n-------------------------------\n\nHar du andre fag i dag?\n\n-------------------------------\n\n");
                }


            }
             
            Console.ReadLine();
        }
    }
}
