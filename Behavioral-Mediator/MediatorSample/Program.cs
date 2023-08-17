

using MediatorSample;

SnackBarMediator mediator = new SnackBarMediator();

HotDogStand leftKitchen = new HotDogStand(mediator);
FrenchFriesStand rightKitchen = new FrenchFriesStand(mediator);

mediator.HotDogStand = leftKitchen;
mediator.FriesStand = rightKitchen;

leftKitchen.Send("Can you send more cooking oil?");

rightKitchen.Send("Sending it now...");
