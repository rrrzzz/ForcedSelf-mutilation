using System.ComponentModel;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ReceiverRayCaster : MonoBehaviour
{
    public float RayDistance = 0.03f;
    public GameObject GuillotineHelpText;
    public FirstPersonController FpsControllerScript;
    public Animator RightArmAnimator;

    private const string RightArmReceiverTag = "RightArmReceiver";
    private const string ReceiverColliderName = "ReceiverCollider";
    private const string ButtonStateName = "ButtonPress";
    private const string RightArmStateName = "CutRight";



    private RaycastHit _hitInfo;
    private Animator _buttonAnimator;
    private bool _hasRightArm = true;
    private bool _hasLeftArm = true;
    private bool _hasLeftLeg = true;
    private bool _hasRightLeg = true;
    private bool _hasHead = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Physics.Raycast(gameObject.transform.position, gameObject.transform.rotation.eulerAngles, out _hitInfo,
            RayDistance)) return;

        if (_hitInfo.collider.transform.name != ReceiverColliderName)
        {
            HideHelpText();
            return;
        }

        ShowHelpText();
        GetButtonAnimator(_hitInfo);

        if (_hitInfo.collider.CompareTag(RightArmReceiverTag) && _hasRightArm && Input.GetKeyDown("E"))
        {
            CutOffLimb(Limbs.RightArm);
        }
    }

    private void GetButtonAnimator(RaycastHit hitInfo) => _buttonAnimator = hitInfo.transform.GetChild(0).GetComponent<Animator>();

    private void CutOffLimb(Limbs limb)
    {
        FpsControllerScript.DisableMovement();
        StartPutLimbIntoReceptacleAnimation(limb);

    }

    private void StartPutLimbIntoReceptacleAnimation(Limbs limb)
    {
        switch (limb)
        {
            case Limbs.RightArm:
                RightArmAnimator.Play(RightArmStateName);
                break;
            default:
                throw new InvalidEnumArgumentException();
        }
    }

    private void ShowHelpText()
    {
        GuillotineHelpText.SetActive(true);
    }

    private void HideHelpText()
    {
        GuillotineHelpText.SetActive(false);
    }

    void EnableButtonAnimator()
    {
        _buttonAnimator.Play(ButtonStateName);
    }
}

public enum Limbs
{
    LeftArm,
    RightArm,
    LeftLeg,
    RightLeg
}