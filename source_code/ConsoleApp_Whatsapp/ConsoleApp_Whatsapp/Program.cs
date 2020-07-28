using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_Whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the file as one string.
            //string text = System.IO.File.ReadAllText(@"C:\_chat_test.txt");

            // Display the file contents to the console. Variable text is a string.
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\chat_2020.txt");
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string fecha_dia;
            string fecha_mes;
            string fecha_año;
            string horario_hora;
            string horario_hora_anterior = "";
            string horario_minuto;
            string horario_minuto_anterior = "";
            string usuario;
            string usuario_actual;
            string usuario_anterior = "";
            string mensaje;

            int fecha_dia_inicial;
            int fecha_dia_final;
            int fecha_mes_inicial;
            int fecha_mes_final;
            int fecha_año_inicial;
            int fecha_año_final;
            int horario_hora_inicial;
            int horario_hora_final;
            int horario_minuto_inicial;
            int horario_minuto_final;
            int horario_segundo_inicial;
            int horario_segundo_final;
            int usuario_inicial;
            int usuario_final;
            int mensaje_inicial;
            int mensaje_final;

            int fecha_actual_inicial;
            int fecha_actual_final;
            string fecha_actual;
            string fecha_anterior = "";

            string user1 = "MiLu";
            string user2 = "Jorge Paredes";

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "chat_2020_arreglado.txt"), false))
            {
                // Display the file contents by using a foreach loop.                
                foreach (string line in lines)
                {
                    if (line == "") {
                        //No hacer nada
                    }
                    else if (line.Substring(0, 1) != "[")
                    {
                        //Escribir línea por línea en txt
                        usuario_actual = usuario_anterior;
                        horario_hora = horario_hora_anterior;
                        horario_minuto = horario_minuto_anterior;                        
                        mensaje = line;                        


                        if (usuario_actual == user1)
                        {
                            outputFile.WriteLine("<div class=\"mensaje user1-mensaje\">");
                        }
                        if (usuario_actual == user2)
                        {
                            outputFile.WriteLine("<div class=\"mensaje user2-mensaje\">");
                        }
                        
                        if (usuario_actual == user1)
                        {
                            outputFile.WriteLine("<p class=\"user1-text\">" + mensaje + "</p>");
                            outputFile.WriteLine("<p class=\"user1-date\">" + horario_hora + ":" + horario_minuto + "</p>");
                        }

                        if (usuario_actual == user2)
                        {
                            outputFile.WriteLine("<p class=\"user2-text\">" + mensaje + "</p>");
                            outputFile.WriteLine("<p class=\"user2-date\">" + horario_hora + ":" + horario_minuto + "</p>");
                        }
                        
                        outputFile.WriteLine("</div>");
                        
                    }
                    else 
                    {
                      

                        // Use a tab to indent each line of the file.
                        Console.WriteLine("\t" + line);

                        fecha_actual_inicial = line.IndexOf("[", 0);
                        fecha_actual_final = line.IndexOf(" ", fecha_actual_inicial + 1);
                        fecha_actual = line.Substring(fecha_actual_inicial + 1, fecha_actual_final - fecha_actual_inicial - 1);
                        Console.WriteLine("\t" + fecha_actual);

                        fecha_dia_inicial = line.IndexOf("[", 0);
                        fecha_dia_final = line.IndexOf("/", fecha_dia_inicial + 1);
                        fecha_dia = line.Substring(fecha_dia_inicial + 1, fecha_dia_final - fecha_dia_inicial - 1);
                        Console.WriteLine("\t" + fecha_dia);

                        fecha_mes_inicial = line.IndexOf("/", fecha_dia_final);
                        fecha_mes_final = line.IndexOf("/", fecha_mes_inicial + 1);
                        fecha_mes = line.Substring(fecha_mes_inicial + 1, fecha_mes_final - fecha_mes_inicial - 1);
                        Console.WriteLine("\t" + fecha_mes);

                        fecha_año_inicial = line.IndexOf("/", fecha_mes_final);
                        fecha_año_final = line.IndexOf(" ", fecha_año_inicial + 1);
                        fecha_año = "20" + line.Substring(fecha_año_inicial + 1, fecha_año_final - fecha_año_inicial - 1);
                        Console.WriteLine("\t" + fecha_año);

                        horario_hora_inicial = line.IndexOf(" ", fecha_año_final);
                        horario_hora_final = line.IndexOf(":", horario_hora_inicial + 1);
                        horario_hora = line.Substring(horario_hora_inicial + 1, horario_hora_final - horario_hora_inicial - 1);
                        Console.WriteLine("\t" + horario_hora);

                        horario_minuto_inicial = line.IndexOf(":", horario_hora_final);
                        horario_minuto_final = line.IndexOf(":", horario_minuto_inicial + 1);
                        horario_minuto = line.Substring(horario_minuto_inicial + 1, horario_minuto_final - horario_minuto_inicial - 1);
                        Console.WriteLine("\t" + horario_minuto);


                        usuario_inicial = line.IndexOf(" ", horario_minuto_final);
                        usuario_final = line.IndexOf(":", usuario_inicial + 1);
                        usuario = line.Substring(usuario_inicial + 1, usuario_final - usuario_inicial - 1);
                        Console.WriteLine("\t" + usuario);

                        usuario_actual = usuario;

                        mensaje_inicial = line.IndexOf(" ", usuario_final);
                        mensaje = line.Substring(mensaje_inicial + 1, line.Length - mensaje_inicial - 1);
                        Console.WriteLine("\t" + mensaje);

                        //Convertir fecha númerica a mes
                        switch (fecha_mes)
                        {
                            case "1":
                                fecha_mes = "ENERO";
                                break;

                            case "2":
                                fecha_mes = "FEBRERO";
                                break;

                            case "3":
                                fecha_mes = "MARZO";
                                break;

                            case "4":
                                fecha_mes = "ABRIL";
                                break;

                            case "5":
                                fecha_mes = "MAYO";
                                break;

                            case "6":
                                fecha_mes = "JUNIO";
                                break;

                            case "7":
                                fecha_mes = "JULIO";
                                break;

                            case "8":
                                fecha_mes = "AGOSTO";
                                break;

                            case "9":
                                fecha_mes = "SEPTIEMBRE";
                                break;

                            case "10":
                                fecha_mes = "OCTUBRE";
                                break;

                            case "11":
                                fecha_mes = "NOVIEMBRE";
                                break;

                            case "12":
                                fecha_mes = "DICIEMBRE";
                                break;
                        }


                        //Escribir línea por línea en txt


                        if (fecha_actual != fecha_anterior)
                        {
                            outputFile.WriteLine("<div class=\"clear-fecha\"></div>");
                            outputFile.WriteLine("<div class=\"fecha\">" + fecha_dia + " DE " + fecha_mes + " DE " + fecha_año + "</div>");
                        }

                        if (usuario_actual == user1)
                        {
                            outputFile.WriteLine("<div class=\"mensaje user1-mensaje\">");
                        }
                        if (usuario_actual == user2)
                        {
                            outputFile.WriteLine("<div class=\"mensaje user2-mensaje\">");
                        }

                        if (usuario_actual != usuario_anterior)
                        {

                            if (usuario_actual == user1)
                            {
                                outputFile.WriteLine("<p class=\"user1-title\">" + usuario_actual + "</p>");
                                outputFile.WriteLine("<p class=\"user1-text\">" + mensaje + "</p>");
                                outputFile.WriteLine("<p class=\"user1-date\">" + horario_hora + ":" + horario_minuto + "</p>");
                            }

                            if (usuario_actual == user2)
                            {
                                outputFile.WriteLine("<p class=\"user2-title\">" + usuario_actual + "</p>");
                                outputFile.WriteLine("<p class=\"user2-text\">" + mensaje + "</p>");
                                outputFile.WriteLine("<p class=\"user2-date\">" + horario_hora + ":" + horario_minuto + "</p>");
                            }

                        }
                        else
                        {
                            if (usuario_actual == user1)
                            {
                                outputFile.WriteLine("<p class=\"user1-text\">" + mensaje + "</p>");
                                outputFile.WriteLine("<p class=\"user1-date\">" + horario_hora + ":" + horario_minuto + "</p>");
                            }

                            if (usuario_actual == user2)
                            {
                                outputFile.WriteLine("<p class=\"user2-text\">" + mensaje + "</p>");
                                outputFile.WriteLine("<p class=\"user2-date\">" + horario_hora + ":" + horario_minuto + "</p>");
                            }

                        }

                        outputFile.WriteLine("</div>");


                        fecha_anterior = fecha_actual;
                        usuario_anterior = usuario_actual;
                        horario_hora_anterior = horario_hora;
                        horario_minuto_anterior = horario_minuto;
                    }
                }
                // Keep the console window open in debug mode.
                Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
            }

        }
    }
}
