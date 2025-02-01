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
                if(HasRecipeWithInput(player.GetFabObject().GetFabObjectSO()))
                {
                    player.GetFabObject().SetFabObjectParent(this); // take it
                }
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

    private bool HasRecipeWithInput(FabObjectSO inputCleaningObjectSO)
    {
        foreach (CleaningRecipeSO cleaningRecipeSO in cleaningRecipeSOArray)
        {
            if(cleaningRecipeSO.input == inputCleaningObjectSO )
            {
                return true;
            }
        }
        return false;
    }

    public override void InteractAlternate(Player player)
    {
        if(HasFabObject() && HasRecipeWithInput(GetFabObject().GetFabObjectSO()))
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
