using System.Web.Http;
using CardSystem.BLL;

namespace CardSystem.WEB.Controllers
{
    public class CardOperationsController : ApiController
    {
		private readonly ICardSystem _cardSystem;

		public CardOperationsController(ICardSystem cardSystem)
		{
			_cardSystem = cardSystem;
		}
    }
}
