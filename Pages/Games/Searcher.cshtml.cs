using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using M05_UF3_P2_Template.App_Code.Model;
namespace M05_UF3_P2_Template.Pages.Games
{
    public class SearcherModel : PageModel
    {
        public List<Game> games = new List<Game>();
        public void OnGet()
        {
            DataTable dt = DatabaseManager.Select("Game", new string[] { "*" }, "");
            foreach (DataRow dataRow in dt.Rows)
            {
                games.Add(new Game(dataRow));
            }
        }
        public void OnPostDelete(int id)
        {
            Product.Remove(id);
            OnGet();
        }
    }
}
