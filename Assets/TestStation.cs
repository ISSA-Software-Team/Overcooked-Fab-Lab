using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestStation : MonoBehaviour, Interactable_Interface
{

    [SerializeField] private string _prompt;
    [SerializeField] private Transform station;

    [SerializeField] private GameObject _minigame;
    [SerializeField] private Transform _minigameParent;

    public string InteractionPrompt => _prompt;

    private bool _interacted = false;

    public bool Interact(Interactor interactor)
    {
        Debug.Log("Interacted with test station!");
        // station.position += Vector3.left;

        if(!_interacted)
        {
            // minigame = Instantiate(_minigame, _minigameParent); // put pos, rot, between mini game and parent
            _minigame.SetActive(true);
            _interacted = true;
        }
        else
        {
            _minigame.SetActive(false);
            _interacted = false;
        }
        return true;
    }

}
