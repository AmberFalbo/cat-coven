# Development Notes

## Local Database Migration Scripts

- `Add-Migration -Name Init -Project CatCoven.MewMewMaterials -StartupProject CatCoven.MewMewMaterials -Context MaterialsDbContext`
- `Update-Database -Project CatCoven.MewMewMaterials -StartupProject CatCoven.MewMewMaterials -Context MaterialsDbContext`

- `Add-Migration -Name Init -Project CatCoven.PurrfectPotions -StartupProject CatCoven.PurrfectPotions -Context PotionsDbContext`
- `Update-Database -Project CatCoven.PurrfectPotions -StartupProject CatCoven.PurrfectPotions -Context PotionsDbContext`

- `Add-Migration -Name Init -Project CatCoven.KittenCharmSpells -StartupProject CatCoven.KittenCharmSpells -Context SpellsDbContext`
- `Update-Database -Project CatCoven.KittenCharmSpells -StartupProject CatCoven.KittenCharmSpells -Context SpellsDbContext`

http://localhost:5197;https://localhost:7064",

## LocalHost

| Service | https | http |
| - | - | - |
| MewMewMaterials | 7064 | 5197 |
| KittenCharmSpells | 7065 | 5198 |
| PurrfectPotions | 7066 |  5199 |
