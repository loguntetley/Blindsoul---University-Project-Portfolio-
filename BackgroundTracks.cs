using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;
using VelcroPhysics.Vector;

namespace BlindSoul
{
    internal static class BackgroundTracks
    {
        private static List<SoundEffect> AudioTracks = new List<SoundEffect>();
        private static List<SoundEffect> SfxTracks = new List<SoundEffect>();

        private static uint songNum;
        private static SoundEffectInstance currentAudioTrack;
        private static SoundEffectInstance NewAudioTrack;
        private static SoundEffectInstance Sounds;
        private static float crossFadingSpeed = 0.01f;
        private static float crossFadingChange = 1f;
        private static bool visibility;

        private static bool Visibility
        {
            set
            {
                if (visibility != value)
                {
                    Console.WriteLine("Calling BattleMusic()");
                    visibility = value;
                    //BattleMusic();
                }
                else
                {
                    //BattleMusic();
                    visibility = value;
                }
            }
        }

        public static void Load(ContentManager content)
        {
            /* 0 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/c-funk-by-kevin-macleod"));
            /* 1 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/cold-funk-by-kevin-macleod"));
            /* 2 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/ether-disco-by-kevin-macleod"));
            /* 3 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/fork-and-spoon-by-kevin-macleod"));
            /* 4 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/funk-game-loop-by-kevin-macleod"));
            /* 5 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/funkorama-by-kevin-macleod"));
            /* 6 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/funky-chunk-by-kevin-macleod"));
            /* 7 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/loopster-by-kevin-macleod"));
            /* 8 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/notanico-merengue-by-kevin-macleod"));
            /* 9 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/plain-loafer-by-kevin-macleod"));
            /* 10 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/protofunk-by-kevin-macleod"));
            /* 11 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/who-likes-to-party-by-kevin-macleod"));
            /* 12 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/clear-waters-by-kevin-macleod"));
            /* 13 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/fretless-by-kevin-macleod"));
            /* 14 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/lobby-time-by-kevin-macleod"));
            /* 15 */
            AudioTracks.Add(content.Load<SoundEffect>("sound/on-my-way-by-kevin-macleod"));

            currentAudioTrack = AudioTracks[0].CreateInstance();
            NewAudioTrack = AudioTracks[8].CreateInstance();

            /* 0 */
            SfxTracks.Add(content.Load<SoundEffect>("SFX/zapsplat_cartoon_twang_spring_wooden_ruler_003_21163(Jump)"));
            /* 1 */
            SfxTracks.Add(content.Load<SoundEffect>("SFX/zapsplat_cartoon_twang_spring_wooden_ruler_003_21163(Jump)"));
            /* 2 */
            SfxTracks.Add(content.Load<SoundEffect>("SFX/zapsplat_industrial_tool_box_small_plastic_set_down_hard_ground_010_34749(walk)"));
        }

        private static void PlayNextSong()
        {
            int currentAreaID = 3;

            switch (currentAreaID)
            {
                case 0:
                    LevelOne();
                    break;

                case 1:
                    LevelTwo();
                    break;

                case 2:
                    LevelThree();
                    break;

                case 3:
                    LevelFour();
                    break;
            }
        }

        private static void LevelOne()
        {
            Console.WriteLine();
            if (currentAudioTrack.State == SoundState.Stopped)
            {
                currentAudioTrack.Volume = 1f;

                switch (songNum)
                {
                    case 0:
                        currentAudioTrack = AudioTracks[1].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 1:
                        currentAudioTrack = AudioTracks[4].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 2:
                        currentAudioTrack = AudioTracks[5].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    default:
                        songNum = 0;
                        LevelOne();
                        return;
                }

                songNum++;
            }
        }

        private static void LevelTwo()
        {
            Console.WriteLine();
            if (currentAudioTrack.State == SoundState.Stopped)
            {
                currentAudioTrack.Volume = 1f;

                switch (songNum)
                {
                    case 0:
                        currentAudioTrack = AudioTracks[8].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 1:
                        currentAudioTrack = AudioTracks[9].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 2:
                        currentAudioTrack = AudioTracks[11].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    default:
                        songNum = 0;
                        LevelTwo();
                        return;
                }

                songNum++;
            }
        }

        private static void LevelThree()
        {
            Console.WriteLine();
            if (currentAudioTrack.State == SoundState.Stopped)
            {
                currentAudioTrack.Volume = 1f;

                switch (songNum)
                {
                    case 0:
                        currentAudioTrack = AudioTracks[0].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 1:
                        currentAudioTrack = AudioTracks[2].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 2:
                        currentAudioTrack = AudioTracks[7].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    default:
                        songNum = 0;
                        LevelThree();
                        return;
                }

                songNum++;
            }
        }

        private static void LevelFour()
        {
            Console.WriteLine();
            if (currentAudioTrack.State == SoundState.Stopped)
            {
                currentAudioTrack.Volume = 1f;

                switch (songNum)
                {
                    case 0:
                        currentAudioTrack = AudioTracks[3].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 1:
                        currentAudioTrack = AudioTracks[6].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    case 2:
                        currentAudioTrack = AudioTracks[10].CreateInstance();
                        currentAudioTrack.Play();
                        break;

                    default:
                        songNum = 0;
                        LevelTwo();
                        return;
                }

                songNum++;
            }
        }

        public static void Update(GameTime gameTime)
        {
            PlayNextSong();
            Visibility = PhysicsManager.inCombat;
            Console.WriteLine("Player is seen: " + visibility);
        }

        private static void CrossFadingIn()
        {
            if (currentAudioTrack.State == SoundState.Playing && currentAudioTrack.Volume >= crossFadingSpeed)
            {
                currentAudioTrack.Volume -= crossFadingSpeed;
            }

            if (currentAudioTrack.Volume <= crossFadingSpeed && NewAudioTrack.State == SoundState.Playing)
            {
                currentAudioTrack.Pause();
            }

            if (currentAudioTrack.Volume <= crossFadingChange && NewAudioTrack.State == SoundState.Stopped)
            {
                NewAudioTrack.Volume = crossFadingSpeed;
                NewAudioTrack.Play();
            }

            if (NewAudioTrack.State == SoundState.Playing && NewAudioTrack.Volume >= crossFadingSpeed && NewAudioTrack.Volume <= (1f - crossFadingSpeed))
            {
                NewAudioTrack.Volume += crossFadingSpeed;
            }
        }

        private static void CrossFadingOut()
        {
            if (NewAudioTrack.State == SoundState.Playing && NewAudioTrack.Volume >= crossFadingSpeed)
            {
                NewAudioTrack.Volume -= crossFadingSpeed;
            }

            if (NewAudioTrack.Volume <= crossFadingSpeed && currentAudioTrack.State == SoundState.Playing)
            {
                NewAudioTrack.Stop();
            }

            if (NewAudioTrack.Volume <= crossFadingChange && currentAudioTrack.State == SoundState.Paused)
            {
                currentAudioTrack.Volume = crossFadingSpeed;
                currentAudioTrack.Play();
            }

            if (currentAudioTrack.State == SoundState.Playing && currentAudioTrack.Volume >= crossFadingSpeed && currentAudioTrack.Volume <= (1f - crossFadingSpeed))
            {
                currentAudioTrack.Volume += crossFadingSpeed;
            }
        }

        public static void StartWalkSound()
        {
            Sounds = SfxTracks[2].CreateInstance();

            if (Sounds.State == SoundState.Stopped)
            {
                Sounds.Play();
            }
        }

        public static void StartJumpSound()
        {
            Sounds = SfxTracks[1].CreateInstance();

            if (Sounds.State == SoundState.Stopped)
            {
                Sounds.Play();
            }
        }

        public static void StopSound()
        {
            if (Sounds.State == SoundState.Playing)
            {
                Sounds.Stop();
            }
        }
    }
}