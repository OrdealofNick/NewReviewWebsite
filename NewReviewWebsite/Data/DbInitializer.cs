using NewReviewWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewReviewWebsite.Data
{
    public class DbInitializer
    {
        public static void Initialize(ReviewContext context) {
            if (context.Artists.Any()) {
                return;
            }
            if (context.Genres.Any()) {
                return;
            }
            if (context.Albums.Any()) {
                return;
            }
            //Artist
            var artists = new Artist[] {
                new Artist{ArtistName="Oh, Sleeper" },
                new Artist{ArtistName="Genesis" },
                new Artist{ArtistName="Saosin" },
                new Artist{ArtistName="Death" },
                new Artist{ArtistName="Dream Theater" },
                new Artist{ArtistName="Every Time I Die" },
                new Artist{ArtistName="Pink Floyd" },
                new Artist{ArtistName="Cinderella" },
                new Artist{ArtistName="Rage Against The Machine" },
                new Artist{ArtistName="Metallica" },
                new Artist{ArtistName="Gojira" },
                new Artist{ArtistName="Between The Buried And Me" },
                new Artist{ArtistName="Mastodon" },
                new Artist{ArtistName="WovenWar" }
            };
            foreach (var a in artists) {
                context.Artists.Add(a);
            }
            context.SaveChanges();

            //Genres
            var grs = new Genre[] {
                new Genre{GenreName="Metal"},
                new Genre{GenreName="Rock"},
                new Genre{GenreName="Hardcore"},
                new Genre{GenreName="Punk"},
                new Genre{GenreName="Pop"},
                new Genre{GenreName="Electronic"},
                new Genre{GenreName="Hiphop/Rap"},
                new Genre{GenreName="Acoustic"},
                new Genre{GenreName="Jazz"},
                new Genre{GenreName="Classical"}
            };
            foreach (var g in grs) {
                context.Genres.Add(g);
            }
            context.SaveChanges();

            //Albums
            var abm = new Album[] {
                new Album{AlbumName="Children of Fire", ArtistID=artists.Single(a=>a.ArtistName=="Oh, Sleeper").ArtistID,
                          Rating = 7, Length="36:44", ReleaseYear= 2011, ReleaseDate = "September 6", GenreID=grs.Single(g=>g.GenreName=="Hardcore").GenreID,
                          Label = "Solid State", Review="No review yet... Stay tuned!"},

                new Album{AlbumName="A Trick of the Tail", ArtistID=artists.Single(a=>a.ArtistName=="Genesis").ArtistID,
                          Rating = 9, Length="51:01", ReleaseYear= 1976, ReleaseDate = "February 2", GenreID=grs.Single(g=>g.GenreName=="Rock").GenreID,
                          Label = "Charisma", Review="During the Lamb tour in 1975, Genesis were getting annoyed at the fans coming up to vocalist Peter " +
                          "Gabriel, congratulating him for the wonderful show and wonderful album, when the two were the entire band's contribution. Later " +
                          "in 1975, after the tour, it was announced that Peter Gabriel had left the band, leaving Genesis without a singer, to which everyone " +
                          "thought all hope was lost and that Genesis split up. This was the band's chance to prove to the fans that they could still be Genesis " +
                          "without their beloved vocalist. Taking up the microphone and drums for this album was the band's legendary drummer Phil Collins, " +
                          "still accompanied by Tony Banks on keyboard, Steve Hackett on guitar and Mike Rutherford as the bassist/guitarist. At everyone's " +
                          "surprised, the band delivered one of their strongest titles in their entire discography, with one of the greatest opening and closing " +
                          "tracks of all time (Dancing on a Volcano and Los Endos, respectively) and quirky art rock pieces such as Robbery, Assault and Battery, " +
                          "Trick of the Tail and Squonk. This album had everything to prove that the band could easily carry on without Gabriel, no matter what " +
                          "anyone said. In the end, Gabriel was still congratulated on A Trick of the Tail even though he was not involved "},

                new Album{AlbumName="Along the Shadow", ArtistID=artists.Single(a=>a.ArtistName=="Saosin").ArtistID,
                          Rating = 6, Length="39:31", ReleaseYear= 2016, ReleaseDate = "May 20", GenreID=grs.Single(g=>g.GenreName=="Hardcore").GenreID,
                          Label = "Epitaph", Review="The first album, since their first album, done with original front man, Anthony Green, known for " +
                          "Circa Survive, comes long overdue, but very much worth the wait. While some of his Circa Survive sound comes through here and " +
                          "there, you're never left guessing who you're listening to. With melodic grooves on Control and the Urge to Pray, to the picked " +
                          "up riffing pace of Racing Toward a Red Light, the album is full of both heart, and surprises. With all the members branching " +
                          "out, while rooted in familiar musical turf, it's a treat to hear them moving a lateral sonic direction. Yes, it's Alt-Rock, but " +
                          "sometimes all you ask for isn't to break new ground, just do what you do, and do it well, and yes, they do it very well."},

                new Album{AlbumName="Scream Bloody Gore", ArtistID=artists.Single(a=>a.ArtistName=="Death").ArtistID,
                          Rating = 8, Length="37:51", ReleaseYear= 1987, ReleaseDate = "May 25", GenreID=grs.Single(g=>g.GenreName=="Metal").GenreID,
                          Label = "Combat", Review="One of the most debated subject in metal is such: who was the first death metal record ever produced? " +
                          "Was it Possessed's Seven Churches in 1985 or Death's Scream Bloody Gore in 1987? Scream Bloody Gore was released in 1987 by " +
                          "Chuck Schuldiner's band, Death, previously named Mantas. The 10-track metal album is one of the most disgusting, brutal and " +
                          "goory record ever to hit the shelves. Never had people stumbled their ears on such brutality, with songs titled Regurgitated " +
                          "Guts, Baptized in Blood, Infernal Death and Torn to Pieces. This is one of Death Metal's finest album, which is impressive since " +
                          "it is considered by many the very first death metal album. So, to answer the question, is Scream Bloody Gore truly the first " +
                          "death metal record, or was the genre already established by its competitor Seven Churches. The simple answer is this: Scream " +
                          "Bloody Gore made what Death Metal is today, revolutionizing the genre forever, spawning countless bands of different subgenres. " +
                          "It may not be the first death metal album, but it's the first true, cover-to-cover death metal record."},

                new Album{AlbumName="The Astonishing", ArtistID=artists.Single(a=>a.ArtistName=="Dream Theater").ArtistID,
                          Rating = 10, Length="130:23", ReleaseYear= 2016, ReleaseDate = "January 29", GenreID=grs.Single(g=>g.GenreName=="Metal").GenreID,
                          Label = "Roadrunner", Review="Dream Theater released their third album with new drummer Mike Mangini with a bang: The Astonishing " +
                          "was the first concept album since 1999's Metropolis pt.2: Scenes from a Memory and the first double album since 2001's Six Degrees " +
                          "of Inner Turbulence. The Astonishing packs thirty-four new tracks (five of those being noise tracks) and clocks at two hours and " +
                          "ten minutes. The album tells the story of Gabriel, a man who rediscovered music, in a world where the Great Northern Empire of " +
                          "the Americas replaced music with noise machines (the noise tracks in the album), and Gabriel's brother's plan to overthrow the " +
                          "empire and bring music back to the world. The lengthy rock opera showcases the talents once more of every member in the group, " +
                          "sounding better than ever. With moving pieces such as When Your Time has Come, Chosen and Begin Again, strong prog-heavy The " +
                          "Gift of Music, Three Days, Ravenskill, Moment of Betrayal, The Walking Shadow and Our New World along with powerful anthems Brother, " +
                          "Can You Hear Me?, The Path That Divides, My Last Farewell and Hymn of a Thousand Voices, The Astonishing is the greatest Dream " +
                          "Theater record in a long time, if not their strongest ever released."},

                new Album{AlbumName="Low Teens", ArtistID=artists.Single(a=>a.ArtistName=="Every Time I Die").ArtistID,
                          Rating = 8, Length="43:10", ReleaseYear= 2016, ReleaseDate = "September 23", GenreID=grs.Single(g=>g.GenreName=="Hardcore").GenreID,
                          Label = "Epitaph", Review="The eighth studio album from Metalcore sweethearts ETID, shows probably their most mature, honest, and " +
                          "rocking material to date. Most of the songs were written while front man Keith Buckleys' wife, Lindsey, was in the hospital with " +
                          "complications during the birth of their daughter, and the anguish and frustration really comes through. From leaving the Rock " +
                          "and Roll lifestyle behind to tackling his own fears of and meaning to life and death, it's real, something the Buckley has been, " +
                          "and continues to do be. The music is fast, heavy, quirky, and just as technically proficient as it is soulful. From Religion " +
                          "of Speed to I Didn’t Want to Join Your Stupid Cult Anyway, it all delivers, and once you pick it up, you wont be able to put " +
                          "it down."},

                new Album{AlbumName="The Division Bell", ArtistID=artists.Single(a=>a.ArtistName=="Pink Floyd").ArtistID,
                          Rating = 7, Length="66:23", ReleaseYear= 1994, ReleaseDate = "March 28", GenreID=grs.Single(g=>g.GenreName=="Rock").GenreID,
                          Label = "EMI/Columbia", Review="The last Pink Floyd record before The Endless River, released in 2014, The Division Bell is one " +
                          "of David Gilmour, Richard Wright and Nick Mason's finest moments. With soaring tunes such as Coming Back to Life and A Great " +
                          "Day for Freedom , the song in which David Gilmore made his guitar truly weep; Marooned and the epic closure High Hopes, The Division " +
                          "Bell is one of Pink Floyd's most underrated gem. A truly relaxing and beautiful workpiece from one of the most influential bands " +
                          "of all time."},

                new Album{AlbumName="Long Cold Winter", ArtistID=artists.Single(a=>a.ArtistName=="Cinderella").ArtistID,
                          Rating = 6, Length="43:51", ReleaseYear= 1988, ReleaseDate = "May 21", GenreID=grs.Single(g=>g.GenreName=="Metal").GenreID,
                          Label = "Mercury (USA)/ Vertigo(Europe)", Review="The second album from Glam Metal turned Blues Rock maestros, Cinderella, marked " +
                          "the turning point in the bands career when they decided to ditch the glitz, and get the blues. Considered both their dirtiest, and " +
                          "prettiest album, the height of the album, the band, and maybe even a whole genre, is their infamous Gypsy Road. The most rocking " +
                          "that blues can be, is rivalled only by Coming Home, arguably one of their most underrated tracks in general. To lump them in " +
                          "with Poison, or Warrant, or Winger (not to knock them at all), would be a shame, as this album sets them apart from the pack, and " +
                          "sets them a place in rock history."},

                new Album{AlbumName="Evil Empire", ArtistID=artists.Single(a=>a.ArtistName=="Rage Against The Machine").ArtistID,
                          Rating = 9, Length="46:34", ReleaseYear= 1996, ReleaseDate = "April 16", GenreID=grs.Single(g=>g.GenreName=="Metal").GenreID,
                          Label = "Epic", Review="Review not yet completed...Stay tuned!"},

                new Album{AlbumName="Hardwired... To Self-Destruct", ArtistID=artists.Single(a=>a.ArtistName=="Metallica").ArtistID,
                          Rating = 8, Length="77:26", ReleaseYear= 2016, ReleaseDate = "November 18", GenreID=grs.Single(g=>g.GenreName=="Metal").GenreID,
                          Label = "Blackened", Review="After eight very long years, Metallica fans are finally rewarded with a double album, the true successor " +
                          "to Death Magnetic (see: Lulu), Hardwired... To Self-Destruct. Clocking at seventy-seven minutes, Hardwired is the longest Metallica " +
                          "album to date (previously held by Death Magnetic, which had a runtime of seventy-four minutes). The album truly feels like a polished," +
                          " refined version of Death Magnetic in almost every aspect, fusing elements from The Black Album and Kill 'Em All. There's really " +
                          "enough to please any Metallica fan in this record, brutal thrash anthems Hardwired to Self-Destruct and Spit out the Bone, hard heavy " +
                          "metal songs Atlas, Rise!, Moth into Flame, Here Comes Revenge and Am I Savage?, this record truly shows Metallica is not dead like " +
                          "many people thought the band were."},

                new Album{AlbumName="From Mars to Sirius", ArtistID=artists.Single(a=>a.ArtistName=="Gojira").ArtistID,
                          Rating = 7, Length="66:52", ReleaseYear= 2005, ReleaseDate = "September 27", GenreID=grs.Single(g=>g.GenreName=="Metal").GenreID,
                          Label = "Listenable, Prosthetic", Review="French monsters of Progressive Death Metal are back again with their epic tale, From Mars to Sirius. " +
                          "Keeping with their thoughtful and poly-rhythmical brutality and well crafted lyrics, it's a tale of war within ourselves. Most of the lyrics " +
                          "align with front man Joe Duplantier's personal views of maintaining the environment, and his veganism (which the other members also share his " +
                          "views, and are regular donors to the Sea Shepherds). With a heavier focus on the atmosphere of the album, it's a great contrast to their normal " +
                          "heavier sound, but it feels more like an extension, instead of replacing some of their sound. If you're looking for heavy and ambient, " +
                          "look no further."},

                new Album{AlbumName="The Lamb Lies Down on Broadway", ArtistID=artists.Single(a=>a.ArtistName=="Genesis").ArtistID,
                          Rating = 10, Length="94:22", ReleaseYear= 1974, ReleaseDate = "November 18", GenreID=grs.Single(g=>g.GenreName=="Rock").GenreID,
                          Label = "Charisma", Review="The sixth and final studio album with co-founder vocalist Peter Gabriel, The Lamb Lies Down on Broadway is simply one " +
                          "of the greatest albums of the 20th century. Released in 1974, the band had decided to tackle a double concept album, clocking a runtime of ninety-four " +
                          "minutes. With Gabriel writing the story and the lyrics, Phil Collins, Tony Banks, Mike Rutherford and Steve Hackett wrote all the music for the " +
                          "album. The story of young graffiti artist Rael is brilliantly told through 23 tracks, in which each stand their own ground whilst expanding the " +
                          "concept of the records. With plenty of genres and styles to please everyone, such as the pop-oriented The Lamb Lies Down on Broadway and Counting " +
                          "out Time, the hard-crushing Fly on a Windshield/Broadway Melody of 1974, In the Cage and Back in N.Y.C., the soft ballad that carried on through " +
                          "almost every Genesis show all the way through 2007 Carpet Crawlers and the bizarre prog-fest The Colony of the Slippermen, The Lamb Lies Down on " +
                          "Broadway is a must-listen for fans of music in general."},
            };

        }
    }
}
