using SolidPrinciples.P02_OpenClosed;
using SolidPrinciples.P03_LiskovSubstitution;
using SolidPrinciples.P04_InterfaceSegregation;
using SolidPrinciples.P05_DependencyInversion;

// P02_OpenClosed ---------------------------------------------------------------------

/*
ShippingService shippingService = new();

IShippingCostStrategy strategy1 = new ExpressShipping();
decimal cost1 = shippingService.CalculateCost(strategy1, 2.5m);

Console.WriteLine($"Costo de envío: ${cost1}");

IShippingCostStrategy strategy2 = new InternationalShipping();
decimal cost2 = shippingService.CalculateCost(strategy2, 7.5m);

Console.WriteLine($"Costo de envío: ${cost2}");
*/

// P03_LiskovSubstitution -------------------------------------------------------------

/*
void MakeBirdMove(Bird bird)
{
    bird.Move();
}

Sparrow sparrow = new();

Penguin penguin = new();

MakeBirdMove(sparrow);
MakeBirdMove(penguin);
*/

// P04_InterfaceSegregation -----------------------------------------------------------

/*
HumanWorker humanWorker = new();
humanWorker.Work();
humanWorker.Eat();

RobotWorker robotWorker = new();
robotWorker.Work();
*/

// P05_DependencyInversion ------------------------------------------------------------

IMessageSender sender = new TelegramSender();

NotificationService notificationService = new(sender);

notificationService.Notify("Hola mundo");