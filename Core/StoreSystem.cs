﻿
namespace ComputerStoreCore
{
    // Система компьютерного магазина
    public class StoreSystem
    {
        // Создать магазин
        public Store CreateStore(StoreBuilder builder, StoreFactory storeFactory,
             DiscountCardsFactory cardsFactory, CustomerFactory custFactory)
        {
            builder.BuildStore(storeFactory);
            builder.BuildCards(cardsFactory);
            builder.BuildCommands(storeFactory, custFactory);
            return builder.GetStore();
        }

        // Создать покупателя
        public Customer CreateCustomer(string name, string username, CustomerFactory factory)
        {
            return factory.MakeCustomer(name, username);
        }
    }
}
