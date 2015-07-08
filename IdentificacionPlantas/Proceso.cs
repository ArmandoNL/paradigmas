using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificacionPlantas
{
    class Proceso
    {
        public String[][] caracteristicas = new String[28][];
        public String[] preguntas = new String[9];
        public String[] especie = new String[28];
        public int[] filasFiltro = new int[20];
        public String formaHoja;
        public int contador;


        public void formaHoja(String forma)
        {
            int j=1;
            for (int i = 1; i < 28; i++) {
                if (caracteristicas[i][1] == forma) {
                    contador++;
                    filasFiltro[0] = contador;
                    filasFiltro[j] = i;
                }

            }

        }











        public void cargarMatriz()
        {
            especie[1] = "Clarisia biflora";
            especie[2] = "Dorstenia choconiana";
            especie[3] = "Ficus americana";
            especie[4] = "Ficus aurea";
            especie[5] = "Ficus brevibracteata";
            especie[6] = "Ficus cervantesiana";
            especie[7] = "Ficus citrifolia";
            especie[8] = "Ficus colubrinae";
            especie[9] = "Ficus costaricana";
            especie[10] = "Ficus crassiuscula";
            especie[11] = "Ficus crocata";
            especie[12] = "Ficus hartwegii";
            especie[13] = "Ficus macbridei";
            especie[14] = "Ficus obtusifolia";
            especie[15] = "Ficus paraensis";
            especie[16] = "Ficus pertusa";
            especie[17] = "Ficus tonduzii";
            especie[18] = "Ficus velutina";
            especie[19] = "Ficus yoponensis";
            especie[20] = "Maquira guianensis";
            especie[21] = "Naucleopsis capirensis";
            especie[22] = "Pseudolmedia glabrata";
            especie[23] = "Pseudolmedia mollis";
            especie[24] = "Sorocea pubivena";
            especie[25] = "Sorocea trophoides";
            especie[26] = "Trophis mexicana";
            especie[27] = "Trophis racemosa";

            caracteristicas[1][1] = "Elíptica";
            caracteristicas[2][1] = "Romboidal";
            caracteristicas[3][1] = "Elíptica";
            caracteristicas[4][1] = "Ovada";
            caracteristicas[5][1] = "Elíptica";
            caracteristicas[6][1] = "Elíptica";
            caracteristicas[7][1] = "Oblonga";
            caracteristicas[8][1] = "Elíptica";
            caracteristicas[9][1] = "Oblonga";
            caracteristicas[10][1] = "Elíptica";
            caracteristicas[11][1] = "Ovada";
            caracteristicas[12][1] = "Elíptica";
            caracteristicas[13][1] = "Ovada";
            caracteristicas[14][1] = "Ovada";
            caracteristicas[15][1] = "Elíptica";
            caracteristicas[16][1] = "Elíptica";
            caracteristicas[17][1] = "Ovada";
            caracteristicas[18][1] = "Ovada";
            caracteristicas[19][1] = "Oblonga";
            caracteristicas[20][1] = "Elíptica";
            caracteristicas[21][1] = "Lanceolada";
            caracteristicas[22][1] = "Elíptica";
            caracteristicas[23][1] = "Elíptica";
            caracteristicas[24][1] = "Oblonga";
            caracteristicas[25][1] = "Elíptica";
            caracteristicas[26][1] = "Elíptica";
            caracteristicas[27][1] = "Elíptica";

            caracteristicas[1][2] = "Aserrado";
            caracteristicas[2][2] = "Aserrado";
            caracteristicas[3][2] = "Entero";
            caracteristicas[4][2] = "Entero";
            caracteristicas[5][2] = "Entero";
            caracteristicas[6][2] = "Entero";
            caracteristicas[7][2] = "Entero";
            caracteristicas[8][2] = "Entero";
            caracteristicas[9][2] = "Entero";
            caracteristicas[10][2] = "Entero";
            caracteristicas[11][2] = "Entero";
            caracteristicas[12][2] = "Entero";
            caracteristicas[13][2] = "Entero";
            caracteristicas[14][2] = "Entero";
            caracteristicas[15][2] = "Entero";
            caracteristicas[16][2] = "Entero";
            caracteristicas[17][2] = "Entero";
            caracteristicas[18][2] = "Entero";
            caracteristicas[19][2] = "Entero";
            caracteristicas[20][2] = "Entero";
            caracteristicas[21][2] = "Aserrado";
            caracteristicas[22][2] = "Aserrado";
            caracteristicas[23][2] = "Aserrado";
            caracteristicas[24][2] = "Aserrado";
            caracteristicas[25][2] = "Aserrado";
            caracteristicas[26][2] = "Entero";
            caracteristicas[27][2] = "Aserrado";

            caracteristicas[1][3] = "Larga";
            caracteristicas[2][3] = "Larga";
            caracteristicas[3][3] = "Corta";
            caracteristicas[4][3] = "Larga";
            caracteristicas[5][3] = "Corta";
            caracteristicas[6][3] = "Corta";
            caracteristicas[7][3] = "Larga";
            caracteristicas[8][3] = "Corta";
            caracteristicas[9][3] = "Larga";
            caracteristicas[10][3] = "Larga";
            caracteristicas[11][3] = "Larga";
            caracteristicas[12][3] = "Corta";
            caracteristicas[13][3] = "Larga";
            caracteristicas[14][3] = "Larga";
            caracteristicas[15][3] = "Larga";
            caracteristicas[16][3] = "Corta";
            caracteristicas[17][3] = "Larga";
            caracteristicas[18][3] = "Larga";
            caracteristicas[19][3] = "Larga";
            caracteristicas[20][3] = "Larga";
            caracteristicas[21][3] = "Corta";
            caracteristicas[22][3] = "Corta";
            caracteristicas[23][3] = "Larga";
            caracteristicas[24][3] = "Larga";
            caracteristicas[25][3] = "Larga";
            caracteristicas[26][3] = "Corta";
            caracteristicas[27][3] = "Larga";

            caracteristicas[1][4] = "Angosta";
            caracteristicas[2][4] = "Ancha";
            caracteristicas[3][4] = "Angosta";
            caracteristicas[4][4] = "Ancha";
            caracteristicas[5][4] = "Angosta";
            caracteristicas[6][4] = "Angosta";
            caracteristicas[7][4] = "Angosta";
            caracteristicas[8][4] = "Angosta";
            caracteristicas[9][4] = "Angosta";
            caracteristicas[10][4] = "Angosta";
            caracteristicas[11][4] = "Ancha";
            caracteristicas[12][4] = "Angosta";
            caracteristicas[13][4] = "Ancha";
            caracteristicas[14][4] = "Ancha";
            caracteristicas[15][4] = "Angosta";
            caracteristicas[16][4] = "Angosta";
            caracteristicas[17][4] = "Ancha";
            caracteristicas[18][4] = "Ancha";
            caracteristicas[19][4] = "Angosta";
            caracteristicas[20][4] = "Angosta";
            caracteristicas[21][4] = "Angosta";
            caracteristicas[22][4] = "Angosta";
            caracteristicas[23][4] = "Ancha";
            caracteristicas[24][4] = "Ancha";
            caracteristicas[25][4] = "Angosta";
            caracteristicas[26][4] = "Angosta";
            caracteristicas[27][4] = "Ancha";

            caracteristicas[1][5] = "Largo";
            caracteristicas[2][5] = "Corto";
            caracteristicas[3][5] = "Corto";
            caracteristicas[4][5] = "Corto";
            caracteristicas[5][5] = "Corto";
            caracteristicas[6][5] = "Corto";
            caracteristicas[7][5] = "Corto";
            caracteristicas[8][5] = "Corto";
            caracteristicas[9][5] = "Corto";
            caracteristicas[10][5] = "Largo";
            caracteristicas[11][5] = "Corto";
            caracteristicas[12][5] = "Corto";
            caracteristicas[13][5] = "Corto";
            caracteristicas[14][5] = "Corto";
            caracteristicas[15][5] = "Corto";
            caracteristicas[16][5] = "Largo";
            caracteristicas[17][5] = "Corto";
            caracteristicas[18][5] = "Corto";
            caracteristicas[19][5] = "Corto";
            caracteristicas[20][5] = "Largo";
            caracteristicas[21][5] = "Corto";
            caracteristicas[22][5] = "Corto";
            caracteristicas[23][5] = "Largo";
            caracteristicas[24][5] = "Largo";
            caracteristicas[25][5] = "Largo";
            caracteristicas[26][5] = "Largo";
            caracteristicas[27][5] = "Largo";

            caracteristicas[1][6] = "Brillante";
            caracteristicas[2][6] = "Opaco";
            caracteristicas[3][6] = "Opaco";
            caracteristicas[4][6] = "Brillante";
            caracteristicas[5][6] = "Brillante";
            caracteristicas[6][6] = "Brillante";
            caracteristicas[7][6] = "Opaco";
            caracteristicas[8][6] = "Brillante";
            caracteristicas[9][6] = "Opaco";
            caracteristicas[10][6] = "Brillante";
            caracteristicas[11][6] = "Brillante";
            caracteristicas[12][6] = "Brillante";
            caracteristicas[13][6] = "Brillante";
            caracteristicas[14][6] = "Brillante";
            caracteristicas[15][6] = "Brillante";
            caracteristicas[16][6] = "Brillante";
            caracteristicas[17][6] = "Opaco";
            caracteristicas[18][6] = "Brillante";
            caracteristicas[19][6] = "Brillante";
            caracteristicas[20][6] = "Brillante";
            caracteristicas[21][6] = "Brillante";
            caracteristicas[22][6] = "Opaco";
            caracteristicas[23][6] = "Opaco";
            caracteristicas[24][6] = "Opaco";
            caracteristicas[25][6] = "Brillante";
            caracteristicas[26][6] = "Opaco";
            caracteristicas[27][6] = "Opaco";

            caracteristicas[1][7] = "Glabro";
            caracteristicas[2][7] = "Glabro";
            caracteristicas[3][7] = "Glabro";
            caracteristicas[4][7] = "Glabro";
            caracteristicas[5][7] = "Glabro";
            caracteristicas[6][7] = "Glabro";
            caracteristicas[7][7] = "Glabro";
            caracteristicas[8][7] = "Glabro";
            caracteristicas[9][7] = "Glabro";
            caracteristicas[10][7] = "Glabro";
            caracteristicas[11][7] = "Glabro";
            caracteristicas[12][7] = "Pubescente";
            caracteristicas[13][7] = "Pubescente";
            caracteristicas[14][7] = "Glabro";
            caracteristicas[15][7] = "Glabro";
            caracteristicas[16][7] = "Glabro";
            caracteristicas[17][7] = "Glabro";
            caracteristicas[18][7] = "Pubescente";
            caracteristicas[19][7] = "Glabro";
            caracteristicas[20][7] = "Glabro";
            caracteristicas[21][7] = "Glabro";
            caracteristicas[22][7] = "Pubescente";
            caracteristicas[23][7] = "Pubescente";
            caracteristicas[24][7] = "Glabro";
            caracteristicas[25][7] = "Glabro";
            caracteristicas[26][7] = "Glabro";
            caracteristicas[27][7] = "Glabro";

            caracteristicas[1][8] = "Pocas";
            caracteristicas[2][8] = "Pocas";
            caracteristicas[3][8] = "Pocas";
            caracteristicas[4][8] = "Pocas";
            caracteristicas[5][8] = "Pocas";
            caracteristicas[6][8] = "Muchas";
            caracteristicas[7][8] = "Muchas";
            caracteristicas[8][8] = "Pocas";
            caracteristicas[9][8] = "Pocas";
            caracteristicas[10][8] = "Muchas";
            caracteristicas[11][8] = "Muchas";
            caracteristicas[12][8] = "Pocas";
            caracteristicas[13][8] = "Pocas";
            caracteristicas[14][8] = "Pocas";
            caracteristicas[15][8] = "Muchas";
            caracteristicas[16][8] = "Pocas";
            caracteristicas[17][8] = "Pocas";
            caracteristicas[18][8] = "Pocas";
            caracteristicas[19][8] = "Muchas";
            caracteristicas[20][8] = "Muchas";
            caracteristicas[21][8] = "Muchas";
            caracteristicas[22][8] = "Muchas";
            caracteristicas[23][8] = "Muchas";
            caracteristicas[24][8] = "Pocas";
            caracteristicas[25][8] = "Pocas";
            caracteristicas[26][8] = "Pocas";
            caracteristicas[27][8] = "Pocas";
        }
    }
}
