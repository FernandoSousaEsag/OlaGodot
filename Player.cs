using Godot;

public partial class Player : Area2D
{
    [Export]
    public float Speed = 100;

    public override void _Process(double delta)
    {
        Vector2 direction = Vector2.Zero;

        if (Input.IsActionPressed("ui_right"))
        {
            direction.X += 1;
        }

        if (Input.IsActionPressed("ui_left"))
        {
            direction.X -= 1;
        }

        if (Input.IsActionPressed("ui_down"))
        {
            direction.Y += 1;
        }

        if (Input.IsActionPressed("ui_up"))
        {
            direction.Y -= 1;
        }

        Position += direction.Normalized() * Speed * (float)delta;
    }
}