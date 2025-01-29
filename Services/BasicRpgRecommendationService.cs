using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgRecommendation.Services
{
    public class BasicRpgRecommendationService : IRpgRecommendationService
    {
        public string RecommendRpg(Dictionary<string, string> answers)
        {
            // Lógica simples de recomendação (pode ser substituída por consulta ao banco de dados)
            // Objetivo aumentar a complexidade da escolha e deixar mais pessoal 
            if (answers["Q1"] == "aberto" && answers["Q2"] == "tempo real" && answers["Q3"] == "sombria" && answers["Q4"] == "sim" && answers["Q5"] == "realistas")
            {
                return "The Witcher 3: Wild Hunt";
            }
            else if (answers["Q1"] == "linear" && answers["Q2"] == "turnos" && answers["Q3"] == "leve" && answers["Q4"] == "não" && answers["Q5"] == "estilizados")
            {
                return "Final Fantasy X";
            }
            else
            {
                return "Skyrim";
            }
        }
    }
}