﻿using MH;
using System;
using System.Collections.Generic;
using System.Text;

namespace MHP2
{
    class AGG : AG
    {
        public AGG(string ruta, Random rand, bool _pmx = false, int num_Cromosomas = 50, float prob_Cruce = 0.7F, float prob_Mutacion = 0.001F, int num_Iteraciones = 500000, int _maxLlamadasFuncionObjetivo = 50000)
        {
            numCromosomas = num_Cromosomas;
            r = rand;
            if (prob_Cruce <= 1f && prob_Cruce >= 0f) probCruce = prob_Cruce;
            else probCruce = 0.7f;

            if (prob_Mutacion <= 1f && prob_Mutacion >= 0f) probMutacion = prob_Mutacion;
            else probMutacion = 0.001f;

            numIteraciones = num_Iteraciones;

            for (int i = 0; i < numCromosomas; i++) poblacion.Add(new QAP(ruta));


            pmx = _pmx;
            estacionario = false;
            memetico = false;

            numCruces = (probCruce * numCromosomas);
            numGenes = poblacion[0].GetLocalizacionesEnUnidades().Count;
            numMutaciones = (probMutacion * numCromosomas * numGenes);

            maxLlamadasFuncionObjetivo = _maxLlamadasFuncionObjetivo;




            Evolucionar();
        }
    }
}
