using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records_Manager
{
    public   class Tags
    {
       public List<string> Data
        {
            get
            {
                for (int i = 0; i < tags.Count; i++)
                {
                    tags[i] = tags[i].Replace("\n", "").Trim();
                }
                return tags;
            }
        }

        public List<string> tags = @"(Camera) First Person
(Camera) Second Person
(Camera) Side View
(Camera) Third Person
(Camera) Top Down View
(Camera) Can Zoom In/Out
(Camera) Can rotate
(Gameplay) Auto Battler
(Gameplay) Mouse Only
(Gameplay) Point-And-click
(Gameplay) Twin Stick
Sports
Simulation
Author's
16-bit-like/Pixel Art
2D
3D
3D-like
Acting
Action
Adult
Adventure
Afterlife
Air
Airplanes
Aliens
Ancient
Animals
Anime
Apocalypse
Archery
Art
Artificial Disaster
Assassination
Atmospherical
Autumn
Based on Anime
Based on Book
Based on Comics/Manga
Based on Movie
Based on Mythology/Legends
Based on TV Series
Based on True Story
Battle Royale
Battleships
Beauty
Betrayal
Betting
Bikes
Biography
Birds
Board Game
Boat
Boss fight
Broken Heart
Building/Creating
Can Change The Controls
Can Customize Character
Can Select Character
Cards
Cartoon-like
Casino
Casual
Chase
Chess
Choices Matter
Co-Op
Comedy
Cold War
Colony
Coming-of-age
Competitive
Conquest
Construction/Assembling
Contains Live-Action Clips
Contemporary
Cooking
Corruption
Crystals
Curse
Cute
DOS / DOSBOX
Dancing
Dark Humour
Dating & Relationships
Designing
Detective Fiction
Dragons
Drama
Drawing/Painting
Dreams/Nightmares
Duels
Dungeon Crawler
Educational
Expansion/Needs Base Game
Expansion/Standalone
Exploration
Family
Fantasy
Fashion
Female Protagonist
Fighting
Forgiveness
Fourth Wall Breaking
Fire
For Children
Frieindship
Forest
Freedom
Funny/Humor
Futuristic
Game Music Type/Ambient
Game Music Type/Electronic
Game Music Type/Other
Game Music Type/Pop
Game Music Type/Rock/Metal
Genie
Ghost Town
Ghosts
Gods/Deities
Good vs Evil
Gothic
Graphic Adventure
Gym/Bodybuilding/Workout
Hack And Slash
Handcraft
Happy
Has AI/Bots
Has Campaign
Has Map Editor
Has Multiplayer
Has Split Screen
Has Super powers
Has VR
Has Voice acting
Happy Ending
Heist
Helicopters
Hidden Objects
Historical
Horror
Horses
Hunting
IT/Computers
Ice
Is Narrated
Immortality
Indie
Insects
Intellectual
Interactive Movie
Islands
Justice
Labyrinth
Languages
Liberation
Logic
Love
Loyalty
MMO
MOBA
Magic
Martial Arts
Masks
Math
Medieval
Military
Monsters
Mountains
Multiverse
Musical/Music
Mystery
Mysticism
Natural Disaster
Naval
New Inventions
Ninja
No Blood
Open World
Open-source
Other Dimentions
Paid Subscription
Parody
Party
Perseverance
Philosophy
Physics
Pirates
Platformer
Player vs Player (PvP)
Playing Musical Instrument
Police
Politics
Possession
Photography
Post-apocalyptic
Poverty
Plants
Preapocalyptic
Prehistoric
Production
Programming
Psychology
Procedurally Generated
Puzzle
Quest
Racing
Real-Time
Realistic
Reboot
Redemption
Resurrection
Rebirth
Religion/Faith
Remake/Remaster
Rescue/Hostages
Resource Management
Resurrection
Revenge
Rhytm
Roguelike
Riot/Revolt/Rebellion
Robots/Android/AI
Romance
Role-Playing
Sacrifice
Sad
Samurai
Sarcasm
Contempt
Allegory
Amplification 
Anagram
Analogy
Metaphor
Oxymoron
Paradox
Satire
Sci Fi
Sniper
Science
Scupture
Shoot Em Up
Shooter
Spy
Side-scroller
Silent Protagonist
Singing/Karaoke
Slavery
Social Media
Space
Space station
Spacecraft
Spring
Stealth
Steampunk
Strategy
Submarines
Suicide
Summer
Superheroes/Supervillains
Supernatural
Surreal
Survival
Swimming/Diving
Tactics
Talk Bubbles
Tanks
Thriller
Time Manipulation
Time Travel
Tower Defense
Toys
Tile-matching
Tragedy
Transplants
Typing
Undead
Underground
Underwater
Unforgiving
Urban
Utopia
Vampires
Vikings
Village
Visual Novel
WWI
WWII
War
Waterfall
Wealthiness
Weapons
Werewolves
Western
Winter
Wrestling
Zombies".Split('\n').ToList();
    }
}
