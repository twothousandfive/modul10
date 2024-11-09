namespace MODUL10;

public class RoomBookingSystem
{
    public void Book(DateTime startDate, DateTime endDate, int people){}
    public void Pay(int sum){}
}

public class CleaningService
{
    public void Clean(int room){}
    public void  Notification(int room, DateTime startDate, DateTime endDate){}
}

public class RestaurantSystem
{
    public void NotificationRestaurant(int room, int people){}
}

public class HotelFacade
{
    public void Reserve(DateTime startTime, DateTime endTime, int people)
    {
        RoomBookingSystem roomBookingSystem = new RoomBookingSystem();
        roomBookingSystem.Book(startTime, endTime, people);
        roomBookingSystem.Pay(1000);
        
        CleaningService cleaningService = new CleaningService();
        cleaningService.Notification(216, startTime, endTime);
        
        RestaurantSystem restaurantSystem = new RestaurantSystem();
        restaurantSystem.NotificationRestaurant(216, people);
    }
}