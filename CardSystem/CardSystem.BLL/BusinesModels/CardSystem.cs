using System;
using AutoMapper;
using CardSystem.DAL;
namespace CardSystem.BLL
{
	public class CardSystem : ICardSystem
	{
		IUnitOfWork Database { get; set; }
		public CardSystem(IUnitOfWork uow)
		{
			Database = uow;
		}
		public void CreateCard(CardDTO cardDTO)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<CardDTO, Card>());
			Database.Cards.Create(Mapper.Map<CardDTO, Card>(cardDTO));
		}

		public void CreateGroup(CardGroupDTO groupDTO)
		{
			Mapper.Initialize(cfg => cfg.CreateMap<CardGroupDTO, CardGroup>());
			Database.Groups.Create(Mapper.Map<CardGroupDTO, CardGroup>(groupDTO));
		}

		public void Dispose()
		{
			Database.Dispose();
		}

		public CardDTO GetCard(int? id)
		{
			//Checking input id
			if (id == null)
				throw new ValidationException("There is no card ID.", "");
			var card = Database.Cards.Get(id.Value);
			//Checking card on exist
			if (card == null)
				throw new ValidationException("Card does not exist.","");
			//Mapping Card to CardDTO
			Mapper.Initialize(cfg => cfg.CreateMap<Card,CardDTO>());
			return Mapper.Map<Card, CardDTO>(card);
		}

		public CardGroupDTO GetGroup(int? id)
		{
			//Checking input id
			if (id == null)
				throw new ValidationException("There is no CardGroup ID.", "");
			var group = Database.Groups.Get(id.Value);
			//Checking group on exist
			if (group == null)
				throw new ValidationException("CardGroup does not exist.", "");
			//Mapping CardGroup to CardGroupDTO
			Mapper.Initialize(cfg => cfg.CreateMap<CardGroup, CardGroupDTO>());
			return Mapper.Map<CardGroup, CardGroupDTO>(group);
		}

	}
}
