namespace Exemplo1Enumeracao.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0, //caso nao seja atribuido valor o c# considera como 0
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
