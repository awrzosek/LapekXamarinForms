using Lapek.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lapek.ViewModels
{
    public class SearchViewModel
    {
        public List<string> SuggestionsList { get; set; }

        public SearchViewModel()
        {
            var searchService = new SearchService();
            SuggestionsList = searchService.GetSuggestions();
        }

        internal List<string> PrepareSuggestions(string keyword)
        {
            string[] keyphrase = keyword.Split(' ');
            var suggestions = new List<string>();
            foreach(string k in keyphrase)
            {
                suggestions.AddRange(SuggestionsList.FindAll(s => s.ToLower().Contains(k.ToLower())));
            }
            return suggestions;
        }
    }
}
