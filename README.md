# MG7
## Devlog
First, my TreeOfBirds script is primarily designed to control when birds appear as the player approaches a tree. I use an array to store four Sparrow objects present in the scene(excluding Sparrow_Start). Within the Update() method, I employ a foreach loop to check each sparrow in the array during every frame. Additionally, I use Vector3.Distance() to calculate the distance between the player and each bird. If this distance is less than or equal to the defined interactionDistance, the script activates the corresponding bird using SetActive(true), causing the bird to appear from the tree. Each bird is activated based on its proximity to the player.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
