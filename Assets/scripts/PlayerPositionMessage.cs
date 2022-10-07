// This could be refactred into multiple message sub-classes, but to make it simple I left it alone.
[System.Serializable]
public class PlayerPositionMessage : GameMessage
{
   public SerializableVector3 velocity;
   public SerializableVector3 enemyVelocity;
   public SerializableVector3 currentPos;
    public SerializableVector3 currentForward;
    public SerializableVector3 enemyForward;
   public int seq;
   public string player;

   public PlayerPositionMessage(string actionIn, string opcodeIn, SerializableVector3 velocityIn,
      SerializableVector3 enemyVelocityIn, SerializableVector3 enemyForwardIn, double timestamp, int seqIn, string playerIn, SerializableVector3 currentPosIn,
      SerializableVector3 currentForwardIn)
      : base(actionIn, opcodeIn)
   {
      velocity = velocityIn;
      enemyVelocity = enemyVelocityIn;
      seq = seqIn;
      player = playerIn;
      currentPos = currentPosIn;
        currentForward = currentForwardIn;
        enemyForward = enemyForwardIn;
   }
}
