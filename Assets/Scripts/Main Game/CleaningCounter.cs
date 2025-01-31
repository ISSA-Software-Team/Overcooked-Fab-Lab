using UnityEngine;

public class CleaningCounter : BaseCounter
{

    [SerializeField] private CleaningRecipeSO[] cleaningRecipeSOArray ;

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
            FabObjectSO outputFabObjectSO = GetOutputForInput(GetFabObject().GetFabObjectSO());
            GetFabObject().DestroySelf();
            FabObject.SpawnFabObject(outputFabObjectSO, this);

        }
    }

    private FabObjectSO GetOutputForInput(FabObjectSO inputCleaningObjectSO)
    {
        foreach (CleaningRecipeSO cleaningRecipeSO in cleaningRecipeSOArray)
        {
            if(cleaningRecipeSO.input == inputCleaningObjectSO )
            {
                return cleaningRecipeSO.output;
            }
        }
        return null;
    }

}
