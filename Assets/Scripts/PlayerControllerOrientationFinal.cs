using UnityEngine;

public class PlayerControllerOrientationFinal : MonoBehaviour
{
    private float _horizontalMovement;
    private float _verticalMovement;
    private Vector3 _direction;

    [SerializeField] private float moveSpeed = 7.0f;

    private SpriteRenderer _spriteRenderer;
    private Animator _animator;
    
    private static readonly int IsWalking = Animator.StringToHash("isWalking");
    private static readonly int VerticalMovement = Animator.StringToHash("verticalMovement");
    
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _horizontalMovement = Input.GetAxisRaw("Horizontal");
        _verticalMovement = Input.GetAxisRaw("Vertical");

        _animator.SetFloat(VerticalMovement, _verticalMovement);
        if (_horizontalMovement != 0 || _verticalMovement != 0)
        {
            _animator.SetBool(IsWalking, true);
            _spriteRenderer.flipX = _horizontalMovement > 0;
            _direction = new Vector3(_horizontalMovement, _verticalMovement, transform.position.z).normalized;
            transform.Translate(_direction * (moveSpeed * Time.deltaTime));
        }
        else
        {
            _animator.SetBool(IsWalking, false);
        }
    }
}
