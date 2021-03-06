﻿// <auto-generated />
using System;
using BukSub.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BukSub.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BukSub.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "dc2e0be1-a196-4e43-a94e-d8b676a8834d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e20deb00-3fd4-4ae9-af11-aad58fb09785",
                            Email = "demo@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "DEMO@EXAMPLE.COM",
                            NormalizedUserName = "DEMO@EXAMPLE.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELVllSq8QkfQEp5Gjf1Oc8SKQkpboufSkiWOBZpCYaVW45wjgew8/+KIqETk5SVVnQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "FZKI2CWMRGFQM4XKVCHRJDVENTMTAXBM",
                            TwoFactorEnabled = false,
                            UserName = "demo@example.com"
                        });
                });

            modelBuilder.Entity("BukSub.Data.Book", b =>
                {
                    b.Property<string>("BookId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = "TheBible/Genesis",
                            Name = "Bible - Genesis",
                            Price = 3.5,
                            Text = @"In the beginning, God created the heavens and the earth.
2 The earth was without form and void, and darkness was over the face of the deep. And the Spirit of God was hovering over the face of the waters.
3 And God said, ""Let there be light,"" and there was light.
4 And God saw that the light was good. And God separated the light from the darkness.
5 God called the light Day, and the darkness he called Night. And there was evening and there was morning, the first day.
6 And God said, ""Let there be an expanse in the midst of the waters, and let it separate the waters from the waters.""
7 And God made the expanse and separated the waters that were under the expanse from the waters that were above the expanse. And it was so.
8 And God called the expanse Heaven. And there was evening and there was morning, the second day.
9 And God said, ""Let the waters under the heavens be gathered together into one place, and let the dry land appear."" And it was so.
10 God called the dry land Earth, and the waters that were gathered together he called Seas.And God saw that it was good."
                        },
                        new
                        {
                            BookId = "TheBible/Samuel 1",
                            Name = "Bible - Samuel",
                            Price = 3.5,
                            Text = @"1 There was a certain man of Ramathaim-zophim of the hill country of Ephraim whose name was Elkanah the son of Jeroham, son of Elihu, son of Tohu, son of Zuph, an Ephrathite.
2 He had two wives. The name of the one was Hannah, and the name of the other, Peninnah. And Peninnah had children, but Hannah had no children.
3 Now this man used to go up year by year from his city to worship and to sacrifice to the LORD of hosts at Shiloh, where the two sons of Eli, Hophni and Phinehas, were priests of the LORD.
4 On the day when Elkanah sacrificed, he would give portions to Peninnah his wife and to all her sons and daughters.
5 But to Hannah he gave a double portion, because he loved her, though the LORD had closed her womb.
6 And her rival used to provoke her grievously to irritate her, because the LORD had closed her womb.
7 So it went on year by year. As often as she went up to the house of the LORD, she used to provoke her. Therefore Hannah wept and would not eat.
8 And Elkanah, her husband, said to her, ""Hannah, why do you weep? And why do you not eat ? And why is your heart sad? Am I not more to you than ten sons?""
9 After they had eaten and drunk in Shiloh, Hannah rose. Now Eli the priest was sitting on the seat beside the doorpost of the temple of the LORD.
10 She was deeply distressed and prayed to the LORD and wept bitterly. "
                        },
                        new
                        {
                            BookId = "UAC Report Files",
                            Name = "UAC REPORT FILES",
                            Price = 28.806975801127798,
                            Text = @"FILE 9REIZDUR
Tempered by the fires of Hell, his iron will remain steadfast through the passage that preys upon the weak. For he alone was the Hell Walker, the Unchained Predator, who sought retribution in all quarters, dark and light, fire and ice, in the beginning, and the end, and he hunted the slaves of Doom with barbarous cruelty; for he passed through the divide as none but the demon had before. 
FILE HR93TE1F
And in his conquest against the blackened souls of the doomed, his prowess was shown. In his crusade, the seraphim (angel) bestowed upon him terrible power and speed, and with his might, he crushed the obsidian pillars of the Blood Temples. He set forth without pity upon the beasts of the nine circles. Unbreakable, incorruptible, unyielding, the Doom Slayer sought to end the dominion of the dark realm.
FILE ZPHVM41A
None could stand before the horde but the Doom Slayer. Despair spread before him like a plague, striking fear into the shadow-dwellers, driving them to deeper and darker pits. But from the depths of the abyss rose The Great One, a champion mightier than all who had come before. The Titan, of immeasurable power and ferocity. He strode upon the plain and faced the Doom Slayer, and a mighty battle was fought on the desolate plains. The Titan fought with the fury of the countless that had fallen at the Doom Slayer's hand, but there fell the Titan, and in his defeat, the shadow horde was routed."
                        },
                        new
                        {
                            BookId = "Thrall's Vision",
                            Name = "Thrall's Vision",
                            Price = 60.0,
                            Text = @"The Prophet: ""The sands of time have run out, son of Durotan... The cries of war echo upon the winds... The remnants of the past scar the land.""
We see a little crow trying to peck out some food from the ground.
The Prophet: ""Which is besieged once again... by conflict...""
We see Orcish Horde running down the hill with noise and war cries, crow has flown away and an orcish catapult flopped down, then we see orcish army running down the hill once again, after that we see opposite hill - human army runs down it.
The Prophet: ""Heroes arise to challenge fate, and lead their brethren to battle... As mortal army rush blindly towards their doom...the Burning Shadow comes to consume us all!""
Infernals begin to fall from the sky, seconds after we see Medivh standing under a heavy rain.
The Prophet: ""You must rally the horde and lead your people to their destiny!""
Thrall awakens. A raven flies from Thrall's Hut.
The Prophet: ""Seek me out.""
"
                        },
                        new
                        {
                            BookId = "Cryptic",
                            Name = "Pattern",
                            Price = 60.0,
                            Text = @"I find sleeping very odd,"" Pattern said. ""I know that all beings in the Physical Realm engage in it. Do you find it pleasant? You fear nonexistence, but is not unconsciousness the same thing?""
""With sleep, it's only temporary.""
""Ah. It is all right, because in the morning, you each return to sentience.""
""Well, that depends on the person,"" Shallan said absently. ""For many of them, 'sentience' might be too generous a term ... .""
Pattern hummed, trying to sort through to the meaning of what she said. Finally, he buzzed an approximation of a laugh."
                        });
                });

            modelBuilder.Entity("BukSub.Data.BookSubscription", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)")
                        .HasMaxLength(450);

                    b.Property<string>("BookId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("UserId", "BookId")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("BookId");

                    b.ToTable("BookSubscription");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BukSub.Data.BookSubscription", b =>
                {
                    b.HasOne("BukSub.Data.Book", "Book")
                        .WithMany("BookSubscriptions")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BukSub.Data.ApplicationUser", "User")
                        .WithMany("BookSubscriptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BukSub.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BukSub.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BukSub.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BukSub.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
