using System;
namespace CardSystem.BLL
{
	public interface ICardService
	{
		void CreateCard(CardDTO cardDTO);
		void CreateGroup(CardGroupDTO groupDTO);

		CardDTO GetCard(int? id);
		CardGroupDTO GetGroup(int? id);

		void Dispose();
	}
}
