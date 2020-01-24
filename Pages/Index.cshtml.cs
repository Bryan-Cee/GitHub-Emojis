using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GithubEmojis;
using GitHubEmojis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GitHubEmojis.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IGithubEmojiService _emojiservice;

        public IndexModel(ILogger<IndexModel> logger, IGithubEmojiService emojiSvc)
        {
            _logger = logger;
            _emojiservice = emojiSvc;
        }

        public IList<Emoji> Emojis { set; get; }

        public async Task OnGet()
        {
            Emojis = (System.Collections.Generic.IList<GitHubEmojis.Models.Emoji>)await _emojiservice.GetEmojis();
        }
    }
}
