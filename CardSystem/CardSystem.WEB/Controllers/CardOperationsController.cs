using System.Web.Http;
using CardSystem.BLL;

namespace CardSystem.WEB.Controllers
{
    public class CardOperationsController : ApiController
    {
		private readonly ICardService _cardSystem;

		public CardOperationsController(ICardService cardSystem)
		{
			_cardSystem = cardSystem;
		}
    }
}
