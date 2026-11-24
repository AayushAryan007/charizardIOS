using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARTrackedImageSpawner : MonoBehaviour
{
    [SerializeField] private GameObject charizardPrefab;
    private GameObject charizard;

    private ARTrackedImageManager aRTrackedImageManager;

    private void OnEnable()
    {
        aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();
        aRTrackedImageManager.trackablesChanged.AddListener(OnImageChanged);
    }

    private void OnImageChanged(ARTrackablesChangedEventArgs<ARTrackedImage> eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            charizard = Instantiate(charizardPrefab, newImage.transform);
        }
    }
}



// using UnityEngine;
// using UnityEngine.Playables;

// // A behaviour that is attached to a playable
// public class NewPlayableBehaviour : PlayableBehaviour
// {
//     // Called when the owning graph starts playing
//     public override void OnGraphStart(Playable playable)
//     {
        
//     }

//     // Called when the owning graph stops playing
//     public override void OnGraphStop(Playable playable)
//     {
        
//     }

//     // Called when the state of the playable is set to Play
//     public override void OnBehaviourPlay(Playable playable, FrameData info)
//     {
        
//     }

//     // Called when the state of the playable is set to Paused
//     public override void OnBehaviourPause(Playable playable, FrameData info)
//     {
        
//     }

//     // Called each frame while the state is set to Play
//     public override void PrepareFrame(Playable playable, FrameData info)
//     {
        
//     }
// }
