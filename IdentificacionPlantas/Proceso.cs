using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace IdentificacionPlantas
{
    class Proceso
    {
        public static String[,] caracteristicas;
        public static String[] preguntas = new String[9];
        public static String[] especie;
        public static int[] filasFiltro = new int[20];
        static List<int> visitados = new List<int>();
            



        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        public void formaHoja(String forma)
        {
            cargarMatriz();
            visitados.Add(1);

            int contador = 0;
            int j = 1;
            for (int i = 0; i < 27; i++)
            {
                if (caracteristicas[i, 1] == forma)
                {
                    contador++;
                    filasFiltro[0] = contador;
                    filasFiltro[j] = i;
                    j++;
                }

            }
            proximaPregunta();
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        public void filtros(String borde, int columna)
        {
            int j = 1;
            int contador = 0;
            for (int i = 1; i <= filasFiltro[0]; i++)
            {
                if (caracteristicas[filasFiltro[i], columna] == borde)
                {
                    contador++;
                    filasFiltro[j] = filasFiltro[i];
                    j++;
                }

            }
            filasFiltro[0] = contador;
            Debug.WriteLine("esto es:" + filasFiltro[0]);
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        public int respuesta()
        {
            return filasFiltro[0];
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        public String Especie()
        {
            return especie[filasFiltro[1]];
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        public void proximaPregunta()
        {
            int[] pregunta = new int[8];

            for (int columna = 0; columna < 8; ++columna)
            {

                if (visitados.Contains(columna) == false)
                {
                    String s1;
                    int i1 = 0, i2 = 0;
                    s1 = caracteristicas[filasFiltro[1], columna];
                    i1++;

                    for (int fila = 2; fila <= filasFiltro[0]; ++fila)
                    {
                        if (caracteristicas[filasFiltro[fila], columna].Equals(s1))
                        {
                            i1++;
                        }
                        else
                        {
                            i2++;
                        }
                    }
                    if (i1 >= i2)
                    {
                        pregunta[columna] = i1 / i2;
                    }
                    else
                    {
                        pregunta[columna] = i2 / i1;
                    }
                }
            }
            activarPregunta(buscarPregunta(pregunta));
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        protected int buscarPregunta(int[] vec)
        {
            int resp = 0;
            int mayor = 0;
            for (int i = 0; i < 8; ++i)
            {
                if (vec[i] > mayor)
                {
                    resp = i;
                    mayor = vec[i];
                }
            }

            visitados.Add(resp);
            
            if (resp == 0)
            {
                resp = 2;
            }
            else
            {
                resp++;
            }
            return resp;
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        protected void activarPregunta(int siguienteForm)
        {
            switch (siguienteForm)
            {
                case 2:
                    new Pregunta2().Show();
                    break;
                case 3:
                    new Pregunta3().Show();
                    break;
                case 4:
                    new Pregunta4().Show();
                    break;
                case 5:
                    new Pregunta5().Show();
                    break;
                case 6:
                    new Pregunta6().Show();
                    break;
                case 7:
                    new Pregunta7().Show();
                    break;
                case 8:
                    new Pregunta8().Show();
                    break;
            }
        }

        /*
         *Efecto:
         *Requiere:
         *Modifica:
         */
        public void cargarMatriz()
        {
            especie = new String[27] { "Clarisia biflora", "Dorstenia choconiana", "Ficus americana", "Ficus aurea", "Ficus brevibracteata ", "Ficus cervantesiana ", "Ficus citrifolia ", "Ficus colubrinae ", "Ficus costaricana ", "Ficus crassiuscula ", "Ficus crocata ", "Ficus hartwegii", "Ficus macbridei", "Ficus obtusifolia", " Ficus paraensis ", "Ficus pertusa ", "Ficus tonduzii ", "Ficus velutina ", "Ficus yoponensis ", "Maquira guianensis ", "Naucleopsis capirensis", " Pseudolmedia glabrata", "Pseudolmedia mollis ", "Sorocea pubivena ", "Sorocea trophoides ", "Trophis mexicana ", "Trophis racemosa" };

            caracteristicas = new String[27, 8] {
                {"Aserrado",	"Elíptica",	"Larga",	"Angosta",	"Largo",	"Brillante",	"Glabro",	"Pocas"},
                {"Aserrado",	"Romboidal",	"Larga",	"Ancha",	"Corto",	"Opaco",	"Glabro",	"Pocas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Corto",	"Opaco",	"Glabro",	"Pocas"},
                {"Entero",	"Obovada",	"Larga",	"Ancha",	"Corto",	"Brillante",	"Glabro",	"Pocas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Corto",	"Brillante",	"Glabro",	"Pocas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Corto",	"Brillante",	"Glabro",	"Muchas"},
                {"Entero",	"Oblonga",	"Larga",	"Angosta",	"Corto",	"Opaco",	"Glabro",	"Muchas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Corto",	"Brillante",	"Glabro",	"Pocas"},
                {"Entero",	"Oblonga",	"Larga",	"Angosta",	"Corto",	"Opaco",	"Glabro",	"Pocas"},
                {"Entero",	"Elíptica",	"Larga",	"Angosta",	"Largo",	"Brillante",	"Glabro",	"Muchas"},
                {"Entero",	"Ovada",	"Larga",	"Ancha",	"Corto",	"Brillante",	"Glabro",	"Muchas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Corto",	"Brillante",	"Pubescente",	"Pocas"},
                {"Entero",	"Ovada",	"Larga",	"Ancha",	"Corto",	"Brillante",	"Pubescente",	"Pocas"},
                {"Entero",	"Obovada",	"Larga",	"Ancha",	"Corto",	"Brillante",	"Glabro",	"Pocas"},
                {"Entero",	"Elíptica",	"Larga",	"Angosta",	"Corto",	"Brillante",	"Glabro",	"Muchas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Largo",	"Brillante",	"Glabro",	"Pocas"},
                {"Entero",	"Ovada",	"Larga",	"Ancha",	"Corto",	"Opaco",	"Glabro",	"Pocas"},
                {"Entero",	"Ovada",	"Larga",	"Ancha",	"Corto",	"Brillante",	"Pubescente",	"Pocas"},
                {"Entero",	"Oblonga",	"Larga",	"Angosta",	"Corto",	"Brillante",	"Glabro",	"Muchas"},
                {"Entero",	"Elíptica",	"Larga",	"Angosta",	"Largo",	"Brillante",	"Glabro",	"Muchas"},
                {"Aserrado",	"Lanceolada",	"Corta",	"Angosta",	"Corto",	"Brillante",	"Glabro",	"Muchas"},
                {"Aserrado",	"Elíptica",	"Corta",	"Angosta",	"Corto",	"Opaco",	"Pubescente",	"Muchas"},
                {"Aserrado",	"Elíptica",	"Larga",	"Ancha",	"Largo",	"Opaco",	"Pubescente",	"Muchas"},
                {"Aserrado",	"Oblonga",	"Larga",	"Ancha",	"Largo",	"Opaco",	"Glabro",	"Pocas"},
                {"Aserrado",	"Elíptica",	"Larga",	"Angosta",	"Largo",	"Brillante",	"Glabro",	"Pocas"},
                {"Entero",	"Elíptica",	"Corta",	"Angosta",	"Largo",	"Opaco",	"Glabro",	"Pocas"},
                {"Aserrado",	"Elíptica",	"Larga",	"Ancha",	"Largo",	"Opaco",	"Glabro",	"Pocas"}
            };
        }
    }
}
