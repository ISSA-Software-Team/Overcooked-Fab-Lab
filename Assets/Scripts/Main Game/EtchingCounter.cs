using UnityEngine;

public class EtchingCounter : BaseCounter
{

    [SerializeField] private FabObjectSO etchedFabObjectSO;

    public override void Interact(Player player)
    {
        if(!HasFabObject())
        {
            if(player.HasFabObject())
            {
                player.GetFabObject().SetFabObjectParent(this);
            }
            else
            {

            }
        }
        else
        {
            if(player.HasFabObject())
            {
                
            }
            else
            {
                GetFabObject().SetFabObjectParent(player);
            }
        }
    }

    public override void InteractAlternate(Player player)
    {
        if(HasFabObject())
        {
            // do etching minigame
            GetFabObject().DestroySelf();
            FabObject.SpawnFabObject(etchedFabObjectSO, this);

        }
    }

}
