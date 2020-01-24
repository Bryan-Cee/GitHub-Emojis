using System.Threading.Tasks;
using System.Collections.Generic;
using GitHubEmojis.Models;

namespace GithubEmojis
{
    public interface IGithubEmojiService
    {
        Task<IList<Emoji>> GetEmojis();
        IList<Emoji> GetEmojisFrom(string content);
    }
}