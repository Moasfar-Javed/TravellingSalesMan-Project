using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsaproject
{
    public partial class DestInfoForm : Form
    {
        int dest;
        public DestInfoForm(int i)
        {
            dest = i;
            InitializeComponent();
            InfoDisplay(i);
            this.Refresh();
        }

        private void DestInfoForm_Load(object sender, EventArgs e)
        {
            infotxtBox.BackColor = Color.FromArgb(4, 41, 58);
        }
        private void InfoDisplay(int i)
        {
            switch (i)
            {
                case 1:
                    {
                        infoLbl.Text = "Burj Khalifa";
                        infotxtBox.Text = "The Burj Khalifa is the tallest building in the world and a global icon. Truly a feat of engineering.\nThe building represents the conceptual heart and soul of the city of Dubai.\n\nAt 828m tall, this magnificent structure is located next to The Dubai Mall and has drawn visitors from all over the world since opening in 2010.\nThe unmatched Burj Khalifa view can be taken in from not one but two observations decks – the two-storey At the Top on the 124th and 125th floors, as well as the world’s highest observation deck(555m) on the 148th floor.";
                        return;
                    }
                case 2:
                    {
                        infoLbl.Text = "Miracle Garden";
                        infotxtBox.Text = "Miracle Garden is one of a kind in the region and in the world for such a unique display and extravagant outdoor recreational destination. \n\nMiracle Garden in its first phase is providing state - of - the - art services and facilities including open parking, VIP parking, sitting areas, prayer room, toilet blocks, ablution facility, security room, first aid room, carts for handicapped visitors, retails and commercial kiosk and all other related services available to facilitate visitors.";
                        return;
                    }
                case 3:
                    {
                        infoLbl.Text = "The Frame";
                        infotxtBox.Text = "If you’re looking for a great way to spend your day in Dubai, visiting the Dubai Frame should definitely be in your list.\n\nStanding tall at 150 m, Dubai Frame provides a bird’s eye view of the city's famous and spectacular skyline, you can experience the views of Old and New Dubai and see how the city has transformed to a one of a kind metropolitan.\n\nVisit the Dubai Frame and enjoy the iconic masterpiece.";
                        return;
                    }
                case 4:
                    {
                        infoLbl.Text = "SkyDive Dubai";
                        infotxtBox.Text = "Experience a breathtaking free-fall and parachute ride with Skydive Dubai, one of the city’s top attractions among intrepid individuals and visiting celebrities. Take the leap above the iconic Palm Jumeirah or over the Arabian desert and see the emirate from an entirely different perspective.\n\nIf you are considering a first-time session, you don’t need to worry. The instructors will guide you through the whole process including a demonstration before even setting foot on a plane.";
                        return;
                    }
                case 5:
                    {
                        infoLbl.Text = "JBR Beach and Walk";
                        infotxtBox.Text = "The Walk at Jumeirah Beach Residence (JBR) is a popular promenade where you can shop, dine and stroll by the sea. The buzzing beachside boulevard offers the opportunity to satisfy your retail cravings with an array of fashion, home and handicraft shops and boutiques.\n\nFeatured shopping attractions include gift shop I Love Dubai, beachwear boutique Rebel Swell and a host of other international retailers.Another highlight is the variety of outdoor pop - up markets where you can check out stalls offering jewellery, food treats and homewares, as well as take in performances by street entertainers.";
                        return;
                    }
                case 6:
                    {
                        infoLbl.Text = "Burj Al Arab";
                        infotxtBox.Text = "Located on its own island, Burj Al Arab Jumeirah features suites overlooking the sea, 9 signature restaurants and a full-service spa. Guests may arrive at the property by chauffeur-driven fleets of Rolls-Royce's or alternatively by a dedicated helicopter transfer service. The terrace offers two swimming pools, 32 luxury cabanas, a restaurant and a bar.\n\nFeaturing floor to ceiling windows with panoramic view of the Arabian Gulf, each suite includes a reactor speaker, complimentary WiFi, and widescreen interactive HD TV. Wireless charger and media hub is also available.";
                        return;
                    }
                case 7:
                    {
                        infoLbl.Text = "Dubai Aquarium";
                        infotxtBox.Text = "Dubai Aquarium & Underwater Zoo is home to thousands of aquatic animals, comprising over 140 species. \nOver 400 Sharks and Rays live in our 10 million litre tank, including Sand Tiger Sharks, Giant Groupers, and a host of other marine species.\n\nA series of carefully designed experiences will allow our visitors to come face to face with our aquatic residents for memorable moments with friends and family.";
                        return;
                    }
                case 8:
                    {
                        infoLbl.Text = "LegoLand Dubai";
                        infotxtBox.Text = "LEGOLAND Dubai and LEGOLAND Water Park are the ultimate year-round theme park destination in the Middle East for families with children from 2-12.\n\nLEGOLAND Dubai and LEGOLAND Water Park are hands-on experiences allowing families to take part in a full day LEGO themed adventures through interactive rides, water slides, models and building experiences.\nJust 20 minutes from the Dubai Marina";
                        return;
                    }
                case 9:
                    {
                        infoLbl.Text = "Aquaventure Waterpark";
                        infotxtBox.Text = "Aquaventure Waterpark is home to iconic record-breaking rides and attractions, such as Trident Tower, Shockwave and Blackout. Located next to Atlantis, The Palm, get the most out of your holiday at this much-loved landmark.\n\nThe enormous theme park features 79 rides across three towers, 26 marine and watersport experiences, private beaches, cool waterslides and children's play areas for all ages";
                        return;
                    }
                case 10:
                    {
                        infoLbl.Text = "Coffee Museum";
                        infotxtBox.Text = "Stop by to discover the origin of coffee, dating all the way back to the legend of Kaldi, a goat herder who is believed to have found the humble coffee bean – and how it made its way into the region from the Ethiopian highlands.\n\nCoffee Museum Dubai also showcases the celebration of coffee culture across the globe, as well as the Arabic traditions. Coffee grinders used in the First World War, historical data dedicated to coffee and old brewing pots are just a few of the artefacts on display.Entry is free, with the museum shop on the ground floor. ";
                        return;
                    }
                case 11:
                    {
                        infoLbl.Text = "Bollywood Park";
                        infotxtBox.Text = "Set foot onto the first ever Bollywood theme park in the world. Located at Dubai Parks and Resorts, this exciting theme park brings the vibrance of Indian cinema all the way to Dubai, in an ode to India's prolific Bollywood industry.\n\nWitness Bollywood movie - making come alive with a variety of flamboyant rides, shows and attractions. Five different zones make up the park, each one celebrating a different part of India’s film industry.Some of the most iconic Bollywood productions, from Sholay to Lagaan, are associated with a ride, or a show.";
                        return;
                    }
                case 12:
                    {
                        infoLbl.Text = "Ski Dubai";
                        infotxtBox.Text = "Try something impossible in Dubai – go skiing in the desert. Located inside the buzzing Mall of the Emirates, you will find one of the most innovative, iconic and exciting tourist attractions to be found in the Middle East.\n\nYou can easily recognise it from afar – it’s the slanted building perched on top of the mall. Surrounded by a cluster of cosy chalets and restaurants, there’s nothing quite like skiing as you watch shoppers pass by in the surrounding windows.";
                        return;
                    }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
