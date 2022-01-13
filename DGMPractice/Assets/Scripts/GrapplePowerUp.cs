public class GrapplePowerUp : PowerupData {
    protected override void PrintName() {
        print("Grapple Powerup");
    }

    protected override void ApplyToPlayer() {
        base.ApplyToPlayer();
        
        print("Give player 1 charge of grapple");
    }
}
