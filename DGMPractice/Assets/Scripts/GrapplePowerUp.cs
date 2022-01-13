public class GrapplePowerUp : PowerupData {
    protected override void PrintName() {
        powerID = 1;
        print("Grapple Powerup");
    }

    protected override void ApplyToPlayer() {
        base.ApplyToPlayer();
        
        print("Give player 1 charge of grapple");
    }
}
