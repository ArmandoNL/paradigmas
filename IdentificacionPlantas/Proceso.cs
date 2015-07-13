using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace IdentificacionPlantas
{
    class Proceso
    {
        public static String[,] caracteristicas;//matriz de características
        public static String[] especie;//contiene las especies de plantas conocidas
        public static int[] filasFiltro = new int[20];//vector para almacenar el # de fila de la matriz que cumple con el filtro
        static List<int> visitados = new List<int>();//lista de preguntas realizadas


        /*
         *Efecto: a partir de la forma realizada, se mueve por la matriz aplicando el filtro por la forma de la hoja. Además carga la matriz.
         *Requiere: que se haga la primera pregunta y entre como parámetro la forma de la hoja.
         *Modifica: la matriz de características, la lista visitados y el vector filasFiltro.
         */
        public void formaHoja(String forma)
        {
            cargarMatriz();//cargamos la matriz de características
            visitados.Add(1);//como siempre realizamos la pregunta 1 primero, la agregamos a la lista de preguntas visitadas

            int contador = 0;//para contar el númere de filas que cumplen con el filtro
            int j = 1;//para movernos por el vector de filas
            for (int i = 0; i < 27; i++)//para movernos por cada una de las filas
            {
                if (caracteristicas[i, 1] == forma)//para verificar que cumpla el filtro
                {
                    contador++;
                    filasFiltro[j] = i;//agregamos al vector la fila en la que estamos
                    j++;
                }
            }
            filasFiltro[0] = contador;//agregamos en la primera posición el número de filas con el que estamos trabajando
        }

        /*
         *Efecto: aplica los 7 filros restantes a las filas que se encuentran en el vector filasFiltro.
         *Requiere: la entrada del estring a filtrar y el número de la columna en la matriz que corresponde a la pregunta.
         *Modifica: modifica el vector filasFiltro.
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
                    filasFiltro[j] = filasFiltro[i];//con cada filro se reduce el # de filas, se actualiza el vector con los filas 
                    //que cumplen el filtro
                    j++;
                }
            }
            filasFiltro[0] = contador;//actualizamos el total de filas
        }

        /*
         *Efecto: devuelve el total de filas que cumplen con el filtro.
         *Requiere: que el vector de filasFiltro esté inicializado.
         *Modifica: N/A
         */
        public int respuesta()
        {
            return filasFiltro[0];
        }

        /*
         *Efecto: devuelve la especie que corresponde a la última fila que se encuentra en filasFiltro.
         *Requiere: que ambos vectores estén inicializados.
         *Modifica: N/A
         */
        public String Especie()
        {
            return especie[filasFiltro[1]];
        }

        /*
         *Efecto: verifica las filas filtradas para determinar cuál pregunta es la más discriminante.
         *Requiere: que el vector filasFiltro, la matriz de características y la lista de visitados estén inicialiados.
         *Modifica: N/A
         */
        public void proximaPregunta()
        {
            int[] pregunta = new int[8];//vector para almacenar las estadísticas de cada pregunta

            for (int columna = 0; columna < 8; ++columna)//para movernos por las preguntas
            {

                if (visitados.Contains(columna) == false)//solo analizamos las preguntas que no se han realizado
                {
                    String s1;//para almacenar la característica
                    int i1 = 0, i2 = 0;//para acumular el número de veces que aparece cada característica
                    s1 = caracteristicas[filasFiltro[1], columna];//guardamos la primera característica que aparece
                    i1++;//actualizamos el contador

                    for (int fila = 2; fila <= filasFiltro[0]; ++fila)//nos movemos por las filas del victor de filtroFilas
                    {
                        if (caracteristicas[filasFiltro[fila], columna].Equals(s1))//verificamos las características para actualizar los contadores
                        {
                            i1++;
                        }
                        else
                        {
                            i2++;
                        }
                    }
                    //en el vector guardamos la división del mayor ente el menor # de apariciones de las características
                    //ya que el resultado mayor indica la pregunta a realizar, es la más discriminante
                    if (i1 == 0 || i2 == 0)//si alguno es 0, esa pregunta no discrimina.
                    {
                        pregunta[columna] = 0;
                    }
                    else if (i1 >= i2)
                    {
                        pregunta[columna] = i1 / i2;
                    }
                    else
                    {
                        pregunta[columna] = i2 / i1;
                    }
                }
            }
            int preg = buscarPregunta(pregunta);//llamamos al método que busca la pregunta a realizar a partir del vector
            activarPregunta(preg);//activa la interfaz correspondiente al # de pregunta
        }

        /*
         *Efecto: busca la pregunta a realizar a partir del vector de estadísticas.
         *Requiere: la entrada del vector.
         *Modifica:N/A
         */
        protected int buscarPregunta(int[] vec)
        {
            int resp = 0;
            int mayor = 0;
            //se mueve por el vector para buscar el valor más alto y guarda la posición, ya 
            //que esta corresponde a la pregunta a realizar
            for (int i = 0; i < 8; ++i)
            {
                if (vec[i] > mayor)//si el valor en el vector es mayor al que tenemos hacemos el cambio
                {
                    resp = i;
                    mayor = vec[i];
                }
            }

            visitados.Add(resp);//agregamos a la lista la pregunta que realizaremos, para no utilizarla nuevamente

            if (resp == 0)//adaptamos la respuesta a los form
            {
                resp = 2;
            }
            else
            {
                resp++;
            }

            return resp;//devolvemos el número de pregunta a realizar
        }

        /*
         *Efecto: activa el form que pertenece a la siguiente pregunta.
         *Requiere: la entrada del número de pregunta a realizar.
         *Modifica: la interfaz.
         */
        protected void activarPregunta(int siguienteForm)
        {
            switch (siguienteForm)//dependiendo del # de pregunta, activa el form correspondiente.
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
         *Efecto: decide a partir del número de filas resultantes del filtro si se encontró o no una solución, o si es necesaria otra pregunta.
         *Requiere: 
         *Modifica: la interfaz.
         */
        public void decidir(String filtro, int columna)
        {
            filtros(filtro, columna);
            if (respuesta() == 0)//si no hay solución
            {
                MessageBox.Show("Su planta no pertenece a la familia de las Moraceae.");
                new FormInicio().Show();

            }
            else if (respuesta() == 1)//si hay solución
            {
                MessageBox.Show("Su planta es: " + Especie() + ".");
                new FormInicio().Show();
            }
            else//si es necesario realizar otra pregunta
            {
                proximaPregunta();
            }
        }

        /*
         *Efecto: carga los datos de la matriz de características y el vector de especies.
         *Requiere: la inicialización de la clase.
         *Modifica: el vector de especie y la matriz de características.
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
