using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    [SerializeField] private Player _target;
    [SerializeField] private float _smoothTime = 0.3f;
    [SerializeField] private float _trackX;
    [SerializeField] private float _trackY;
    [SerializeField] private float _trackZ;
    
    private Vector3 _velocity = Vector3.zero;

    private void Update()
    {
        Vector3 targetPosition = _target.transform.TransformPoint(new Vector3(_trackX, _trackY, 0.0f));
        targetPosition.z = _trackZ;

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
    }
}
