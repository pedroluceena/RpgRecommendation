using Microsoft.AspNetCore.Mvc.RazorPages;
using RpgRecommendation.Services;
using System.Collections.Generic;

namespace RpgRecommendation.Pages
{
    public class RecommendationModel : PageModel
    {
        private readonly IRpgRecommendationService _rpgRecommendationService;

        public Dictionary<string, string> Questions { get; set; } = new Dictionary<string, string>
        {
            { "Q1", "Você prefere um mundo aberto ou um mundo mais linear?" },
            { "Q2", "Você gosta de combate em tempo real ou por turnos?" },
            { "Q3", "Você prefere uma história mais sombria ou mais leve?" },
            { "Q4", "Você gosta de customização de personagens?" },
            { "Q5", "Você prefere gráficos realistas ou estilizados?" }
        };

        public Dictionary<string, string> Answers { get; set; } = new Dictionary<string, string>();

        public string RecommendedRpg { get; set; }

        public RecommendationModel(IRpgRecommendationService rpgRecommendationService)
        {
            _rpgRecommendationService = rpgRecommendationService;
        }

        public void OnGet()
        {
            // Inicializa as respostas
            foreach (var key in Questions.Keys)
            {
                Answers[key] = "";
            }
        }

        public void OnPost()
        {
            // Processa as respostas
            foreach (var key in Questions.Keys)
            {
                Answers[key] = Request.Form[key];
            }

            // Usa o serviço para recomendar um RPG
            RecommendedRpg = _rpgRecommendationService.RecommendRpg(Answers);
        }
    }
}