using UnityEngine;

public class BaseCounter : MonoBehaviour, IFabObjectParent
{

    [SerializeField] private Transform counterTopPoint;
    
    private FabObject fabObject;

    public virtual void Interact(Player player)
    {
        Debug.Log("BaseCounter.Interact should not be triggered");
    }

    public virtual void InteractAlternate(Player player)
    {
        Debug.Log("BaseCounter.Interact should not be triggered");
    }

    
    public Transform GetFabObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public void SetFabObject(FabObject fabObject)
    {
        this.fabObject = fabObject;
    }

    public FabObject GetFabObject()
    {
        return fabObject;
    }

    public void ClearFabObject()
    {
        fabObject = null;
    }

    public bool HasFabObject()
    {
        return fabObject != null;
    }
}
