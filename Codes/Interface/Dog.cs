namespace Interface;

public class Dog : Animal
{
    private string _sound = "";
    public override string GetSound()
    {
        return string.IsNullOrEmpty(_sound) ? base.GetSound() : _sound;
    }
}