using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class Boss : MonoBehaviour
{
    // Liste des patterns d'attaque
    [Header("Attaque Patterns")]
    public List<AttackPattern> attackPatterns = new List<AttackPattern>();

    [Tooltip("Nombre minimum de patterns")]
    public int minPatterns = 1;

    public float attackCooldown = 2f;  // Temps entre chaque attaque
    private float nextAttackTime = 0f;  // Temps jusqu'à la prochaine attaque

    void Start()
    {
        // Si moins de patterns que le minimum, en ajouter un par défaut
        while (attackPatterns.Count < minPatterns)
        {
            attackPatterns.Add(new AttackPattern()); // Ajoute un pattern par défaut (vide)
        }
    }

    void Update()
    {
        // Si le cooldown est passé, on génère un pattern d'attaque aléatoire
        if (Time.time >= nextAttackTime && attackPatterns.Count > 0)
        {
            // Générer un nombre aléatoire entre 0 et la taille de la liste des patterns
            int patternIndex = Random.Range(0, attackPatterns.Count);

            // Appeler le pattern aléatoire
            attackPatterns[patternIndex]?.Invoke();

            // Mettre à jour le temps pour la prochaine attaque
            nextAttackTime = Time.time + attackCooldown;
        }
    }
}

// Classe qui définit un pattern d'attaque avec une action
[System.Serializable]
public class AttackPattern
{
    public string patternName;
    public UnityEvent patternAction;

    // Appeler l'action associée au pattern
    public void Invoke()
    {
        patternAction.Invoke();
    }
}