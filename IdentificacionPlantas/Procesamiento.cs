using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdentificacionPlantas
{
    class Procesamiento
    {
        String[][] caracteristicas = new String[28][];
        String[] preguntas = new String[9];
        String[] especie = new String[28];

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

            caracteristicas[0][0] = "Aserrado";


        }


    }
}
