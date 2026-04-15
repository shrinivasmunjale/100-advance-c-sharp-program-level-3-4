using System;

//First interface
interface ICamera
{
    void TakePhoto();
}

//second interface
interface IMusicPlayer
{
    void PlayMusic();
}

//class implementing multiple interfaces
class Smartphone : ICamera, IMusicPlayer
{
    public void TakePhoto()
    {
        Console.WriteLine("Phot Captured");
    }
    public void PlayMusic()
    {
        Console.WriteLine("Playing Music");
    }
}
class Program
{
    static void Main()
    {
        Smartphone phone = new Smartphone();
        phone.TakePhoto();
        phone.PlayMusic();
    }
}