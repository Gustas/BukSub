﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BukSub.Data.Migrations
{
    public partial class AddBookSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Name", "Price", "Text" },
                values: new object[,]
                {
                    { "TheBible/Genesis", "Bible - Genesis", 3.5, @"In the beginning, God created the heavens and the earth.
                2 The earth was without form and void, and darkness was over the face of the deep. And the Spirit of God was hovering over the face of the waters.
                3 And God said, ""Let there be light,"" and there was light.
                4 And God saw that the light was good. And God separated the light from the darkness.
                5 God called the light Day, and the darkness he called Night. And there was evening and there was morning, the first day.
                6 And God said, ""Let there be an expanse in the midst of the waters, and let it separate the waters from the waters.""
                7 And God made the expanse and separated the waters that were under the expanse from the waters that were above the expanse. And it was so.
                8 And God called the expanse Heaven. And there was evening and there was morning, the second day.
                9 And God said, ""Let the waters under the heavens be gathered together into one place, and let the dry land appear."" And it was so.
                10 God called the dry land Earth, and the waters that were gathered together he called Seas.And God saw that it was good." },
                    { "TheBible/Samuel 1", "Bible - Samuel", 3.5, @"1 There was a certain man of Ramathaim-zophim of the hill country of Ephraim whose name was Elkanah the son of Jeroham, son of Elihu, son of Tohu, son of Zuph, an Ephrathite.
                2 He had two wives. The name of the one was Hannah, and the name of the other, Peninnah. And Peninnah had children, but Hannah had no children.
                3 Now this man used to go up year by year from his city to worship and to sacrifice to the LORD of hosts at Shiloh, where the two sons of Eli, Hophni and Phinehas, were priests of the LORD.
                4 On the day when Elkanah sacrificed, he would give portions to Peninnah his wife and to all her sons and daughters.
                5 But to Hannah he gave a double portion, because he loved her, though the LORD had closed her womb.
                6 And her rival used to provoke her grievously to irritate her, because the LORD had closed her womb.
                7 So it went on year by year. As often as she went up to the house of the LORD, she used to provoke her. Therefore Hannah wept and would not eat.
                8 And Elkanah, her husband, said to her, ""Hannah, why do you weep? And why do you not eat ? And why is your heart sad? Am I not more to you than ten sons?""
                9 After they had eaten and drunk in Shiloh, Hannah rose. Now Eli the priest was sitting on the seat beside the doorpost of the temple of the LORD.
                10 She was deeply distressed and prayed to the LORD and wept bitterly. " },
                    { "UAC Report Files", "UAC REPORT FILES", 28.806975801127798, @"FILE 9REIZDUR
                Tempered by the fires of Hell, his iron will remain steadfast through the passage that preys upon the weak. For he alone was the Hell Walker, the Unchained Predator, who sought retribution in all quarters, dark and light, fire and ice, in the beginning, and the end, and he hunted the slaves of Doom with barbarous cruelty; for he passed through the divide as none but the demon had before. 
                FILE HR93TE1F
                And in his conquest against the blackened souls of the doomed, his prowess was shown. In his crusade, the seraphim (angel) bestowed upon him terrible power and speed, and with his might, he crushed the obsidian pillars of the Blood Temples. He set forth without pity upon the beasts of the nine circles. Unbreakable, incorruptible, unyielding, the Doom Slayer sought to end the dominion of the dark realm.
                FILE ZPHVM41A
                None could stand before the horde but the Doom Slayer. Despair spread before him like a plague, striking fear into the shadow-dwellers, driving them to deeper and darker pits. But from the depths of the abyss rose The Great One, a champion mightier than all who had come before. The Titan, of immeasurable power and ferocity. He strode upon the plain and faced the Doom Slayer, and a mighty battle was fought on the desolate plains. The Titan fought with the fury of the countless that had fallen at the Doom Slayer's hand, but there fell the Titan, and in his defeat, the shadow horde was routed." },
                    { "Thrall's Vision", "Thrall's Vision", 60.0, @"The Prophet: ""The sands of time have run out, son of Durotan... The cries of war echo upon the winds... The remnants of the past scar the land.""
                We see a little crow trying to peck out some food from the ground.
                The Prophet: ""Which is besieged once again... by conflict...""
                We see Orcish Horde running down the hill with noise and war cries, crow has flown away and an orcish catapult flopped down, then we see orcish army running down the hill once again, after that we see opposite hill - human army runs down it.
                The Prophet: ""Heroes arise to challenge fate, and lead their brethren to battle... As mortal army rush blindly towards their doom...the Burning Shadow comes to consume us all!""
                Infernals begin to fall from the sky, seconds after we see Medivh standing under a heavy rain.
                The Prophet: ""You must rally the horde and lead your people to their destiny!""
                Thrall awakens. A raven flies from Thrall's Hut.
                The Prophet: ""Seek me out.""
                " },
                    { "Cryptic", "Pattern", 60.0, @"I find sleeping very odd,"" Pattern said. ""I know that all beings in the Physical Realm engage in it. Do you find it pleasant? You fear nonexistence, but is not unconsciousness the same thing?""
                ""With sleep, it's only temporary.""
                ""Ah. It is all right, because in the morning, you each return to sentience.""
                ""Well, that depends on the person,"" Shallan said absently. ""For many of them, 'sentience' might be too generous a term ... .""
                Pattern hummed, trying to sort through to the meaning of what she said. Finally, he buzzed an approximation of a laugh." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "Cryptic");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "TheBible/Genesis");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "TheBible/Samuel 1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "Thrall's Vision");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: "UAC Report Files");
        }
    }
}
