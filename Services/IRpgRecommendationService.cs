using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgRecommendation.Services
{
    public interface IRpgRecommendationService
    {
        string RecommendRpg(Dictionary<string, string> answers);
    }
}