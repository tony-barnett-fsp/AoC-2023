using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Day18
    {
        private string _input = "R 4 (#2dbea0)\r\nU 7 (#771413)\r\nR 5 (#991f00)\r\nU 4 (#0db993)\r\nR 3 (#1c6ab0)\r\nD 11 (#67d2f3)\r\nR 4 (#778c30)\r\nU 3 (#7535c3)\r\nR 2 (#2afd02)\r\nU 3 (#84a633)\r\nR 5 (#7d6492)\r\nU 7 (#236953)\r\nR 4 (#4598b2)\r\nU 5 (#5c4bc3)\r\nR 7 (#2f17b2)\r\nU 4 (#76bf51)\r\nR 5 (#701390)\r\nU 8 (#388c61)\r\nL 5 (#701392)\r\nD 5 (#550f91)\r\nL 6 (#3dc292)\r\nU 5 (#43af93)\r\nL 8 (#311ed2)\r\nU 5 (#574df3)\r\nR 9 (#21efb2)\r\nU 4 (#912163)\r\nR 2 (#8a10e2)\r\nD 4 (#83a213)\r\nR 8 (#7a0f52)\r\nU 6 (#2f5653)\r\nL 3 (#17f722)\r\nU 3 (#53bf23)\r\nL 10 (#012322)\r\nU 2 (#48b7b1)\r\nL 4 (#42cc22)\r\nU 4 (#85b173)\r\nR 7 (#430832)\r\nU 2 (#85b171)\r\nR 11 (#41d692)\r\nU 3 (#48b7b3)\r\nR 7 (#009022)\r\nU 10 (#546063)\r\nL 4 (#272ba2)\r\nU 9 (#666b83)\r\nL 4 (#3bd310)\r\nU 7 (#86d473)\r\nL 5 (#669640)\r\nU 2 (#498c81)\r\nL 6 (#053490)\r\nD 5 (#790f51)\r\nR 5 (#6e8fe0)\r\nD 6 (#3c33a3)\r\nL 5 (#1a8e20)\r\nD 7 (#866833)\r\nL 6 (#69f7e0)\r\nU 10 (#9e4e83)\r\nL 4 (#66bb50)\r\nD 11 (#15bda1)\r\nL 7 (#4ab050)\r\nD 11 (#023e41)\r\nR 7 (#5da0c0)\r\nD 3 (#659ca1)\r\nL 3 (#1bb4e2)\r\nD 6 (#58efe3)\r\nL 2 (#644bd2)\r\nD 3 (#58efe1)\r\nL 3 (#4f9712)\r\nU 2 (#605551)\r\nL 10 (#1d55e0)\r\nU 4 (#592e11)\r\nL 3 (#87e710)\r\nD 10 (#592e13)\r\nL 7 (#2a5ad0)\r\nU 10 (#104021)\r\nL 8 (#1ca4d0)\r\nD 6 (#1c7af1)\r\nL 7 (#8c8c30)\r\nD 4 (#0eb613)\r\nL 6 (#913b20)\r\nU 4 (#033803)\r\nL 3 (#30fd00)\r\nD 4 (#8be0c3)\r\nL 3 (#839f00)\r\nD 4 (#6cda13)\r\nR 9 (#0aa6e0)\r\nD 2 (#749731)\r\nR 9 (#165730)\r\nD 5 (#b08bc1)\r\nL 4 (#19b980)\r\nD 3 (#4d9383)\r\nL 8 (#805ee0)\r\nD 2 (#24e933)\r\nL 6 (#4b0bb0)\r\nD 3 (#23c683)\r\nL 4 (#1584b0)\r\nD 3 (#5fc993)\r\nL 6 (#2a8012)\r\nD 5 (#02b643)\r\nL 9 (#af69b2)\r\nU 4 (#02b641)\r\nL 2 (#070582)\r\nU 8 (#374643)\r\nL 7 (#3c22b2)\r\nU 5 (#1d4c33)\r\nL 2 (#6f1172)\r\nU 6 (#1221e1)\r\nL 6 (#7319e2)\r\nU 5 (#1221e3)\r\nL 4 (#2937b2)\r\nU 4 (#70a653)\r\nL 8 (#51c192)\r\nU 5 (#94c223)\r\nL 4 (#7064f0)\r\nU 9 (#6040a3)\r\nL 3 (#7064f2)\r\nU 6 (#3e8783)\r\nL 6 (#629342)\r\nU 2 (#26e081)\r\nL 10 (#1bdbb2)\r\nU 7 (#90ec41)\r\nL 3 (#1754d2)\r\nU 6 (#49f921)\r\nL 11 (#2b2a02)\r\nU 3 (#32de91)\r\nL 3 (#2b2a00)\r\nU 4 (#6f8c21)\r\nL 14 (#0d4282)\r\nU 3 (#6c9983)\r\nR 9 (#9020d2)\r\nU 3 (#6cf751)\r\nR 7 (#850c32)\r\nU 5 (#6cf753)\r\nR 2 (#370ab2)\r\nU 3 (#6c9981)\r\nR 9 (#131dd2)\r\nU 5 (#98b9e3)\r\nR 3 (#266402)\r\nU 6 (#1580a3)\r\nR 8 (#5ccf92)\r\nU 4 (#5f3883)\r\nR 8 (#4d14e2)\r\nU 3 (#13e193)\r\nR 5 (#679462)\r\nU 10 (#576a43)\r\nR 6 (#009950)\r\nU 8 (#17dd83)\r\nR 4 (#63f5f0)\r\nU 3 (#280e23)\r\nR 5 (#062230)\r\nU 2 (#9558c3)\r\nR 5 (#2ecc50)\r\nU 7 (#5bec91)\r\nR 6 (#684080)\r\nD 12 (#ac9351)\r\nR 5 (#445d50)\r\nD 13 (#305861)\r\nR 3 (#264ce0)\r\nD 5 (#9b3013)\r\nR 11 (#3f1d42)\r\nD 7 (#1b09f3)\r\nR 3 (#3f1d40)\r\nU 5 (#829e43)\r\nR 3 (#37f240)\r\nU 5 (#320d13)\r\nR 6 (#2f42d0)\r\nU 4 (#1e0583)\r\nR 5 (#8c1210)\r\nU 5 (#68c3f3)\r\nR 9 (#1eab80)\r\nU 9 (#1cd573)\r\nR 3 (#a58342)\r\nU 7 (#27ab93)\r\nR 6 (#2c8af2)\r\nU 7 (#5401e3)\r\nR 3 (#94dbe2)\r\nU 4 (#2f3553)\r\nR 5 (#2764e2)\r\nU 7 (#a9a313)\r\nL 9 (#644720)\r\nU 6 (#6e5501)\r\nL 5 (#72a8a0)\r\nU 6 (#58f9d3)\r\nL 6 (#1dc690)\r\nD 6 (#155b33)\r\nL 4 (#9998a0)\r\nU 3 (#42aae3)\r\nL 10 (#919510)\r\nU 7 (#5c42a3)\r\nR 3 (#409970)\r\nU 4 (#6e6001)\r\nR 3 (#78d530)\r\nU 3 (#741881)\r\nR 8 (#4a62c0)\r\nU 7 (#698ee1)\r\nR 6 (#28dd90)\r\nD 8 (#1c4631)\r\nR 7 (#317370)\r\nD 2 (#a7fb31)\r\nR 4 (#0c31b0)\r\nD 4 (#a78f73)\r\nR 3 (#261040)\r\nU 9 (#3049f3)\r\nR 3 (#623ac0)\r\nU 3 (#7dd4e3)\r\nR 4 (#70d6f0)\r\nD 10 (#05d8e3)\r\nR 7 (#485d50)\r\nD 9 (#83adc1)\r\nR 4 (#42d970)\r\nD 4 (#28f2c3)\r\nR 8 (#12be40)\r\nD 10 (#8b8881)\r\nR 6 (#4eeb80)\r\nD 2 (#7543a1)\r\nR 7 (#20b000)\r\nD 6 (#b74541)\r\nR 2 (#234710)\r\nD 5 (#3fdf61)\r\nR 3 (#711bd0)\r\nD 4 (#241a11)\r\nR 6 (#9281f0)\r\nD 6 (#2e3a21)\r\nR 7 (#810170)\r\nD 8 (#673c21)\r\nR 2 (#157b50)\r\nD 4 (#4fd5e1)\r\nR 4 (#390440)\r\nD 6 (#599881)\r\nR 6 (#1d71d0)\r\nD 9 (#991d81)\r\nR 6 (#217ac0)\r\nD 3 (#395ab1)\r\nR 4 (#6dfea0)\r\nU 8 (#560f21)\r\nR 7 (#869760)\r\nU 4 (#797f23)\r\nR 7 (#4b0e30)\r\nU 10 (#1f54e3)\r\nR 3 (#4b0e32)\r\nU 3 (#8fb353)\r\nR 4 (#2db020)\r\nU 9 (#42ffa1)\r\nL 6 (#2377e0)\r\nU 9 (#41fc51)\r\nL 2 (#6fe090)\r\nU 4 (#6535f1)\r\nL 3 (#389170)\r\nU 5 (#0f7b51)\r\nL 8 (#2a3200)\r\nU 2 (#0eecb1)\r\nL 3 (#af12b0)\r\nU 7 (#286713)\r\nR 4 (#0d6c40)\r\nU 8 (#277651)\r\nR 2 (#3568a0)\r\nU 6 (#689c31)\r\nR 10 (#384100)\r\nU 6 (#44f061)\r\nR 6 (#5960f0)\r\nU 8 (#a3a751)\r\nR 4 (#542c80)\r\nU 5 (#8f4353)\r\nR 11 (#82cfa0)\r\nD 3 (#8abc43)\r\nR 2 (#82cfa2)\r\nD 8 (#5eaaa3)\r\nR 2 (#a37510)\r\nD 8 (#286711)\r\nR 7 (#4355f0)\r\nD 6 (#1e42b1)\r\nR 5 (#5f3f22)\r\nD 4 (#2f03c1)\r\nR 6 (#26af60)\r\nD 4 (#1168f1)\r\nR 7 (#8090f0)\r\nU 3 (#6a1771)\r\nR 5 (#3347f0)\r\nU 5 (#41de51)\r\nR 9 (#686562)\r\nU 4 (#722151)\r\nR 4 (#2ea082)\r\nU 6 (#722153)\r\nR 4 (#438262)\r\nD 14 (#45f231)\r\nR 2 (#282b32)\r\nD 4 (#6e0cf1)\r\nR 4 (#524462)\r\nD 9 (#44ce21)\r\nL 3 (#562272)\r\nD 11 (#1a8bc1)\r\nL 7 (#36c770)\r\nD 5 (#5f9801)\r\nL 3 (#96fd60)\r\nU 7 (#4d42d1)\r\nL 7 (#96fd62)\r\nU 9 (#41df01)\r\nL 6 (#36c772)\r\nD 3 (#404551)\r\nL 8 (#08ca82)\r\nD 7 (#2a19c1)\r\nL 2 (#358392)\r\nD 10 (#6b7ac1)\r\nR 3 (#353c92)\r\nD 5 (#6b7ac3)\r\nR 4 (#63bbb2)\r\nD 10 (#5b84f3)\r\nR 7 (#3b2112)\r\nD 4 (#0c7863)\r\nR 3 (#a9dc20)\r\nD 11 (#38fd13)\r\nR 6 (#2efda0)\r\nU 9 (#3c8d83)\r\nR 9 (#708832)\r\nU 7 (#0e81a3)\r\nL 6 (#685192)\r\nU 2 (#63c483)\r\nL 3 (#134732)\r\nU 12 (#583333)\r\nR 4 (#922732)\r\nD 9 (#7cf091)\r\nR 4 (#8e4842)\r\nD 2 (#3b7ae1)\r\nR 5 (#4a0de0)\r\nD 9 (#3e45d1)\r\nR 7 (#62da10)\r\nU 10 (#2c5061)\r\nR 5 (#2a5742)\r\nU 2 (#4521f1)\r\nR 3 (#8290b2)\r\nU 4 (#3fdda1)\r\nL 2 (#3eadc2)\r\nU 7 (#7a01c1)\r\nL 6 (#12f1d0)\r\nU 7 (#3bc561)\r\nR 5 (#4322c0)\r\nU 5 (#51d0c1)\r\nR 7 (#618d00)\r\nU 4 (#4dc971)\r\nL 8 (#42ce90)\r\nU 2 (#2d66a1)\r\nL 4 (#5e2bf0)\r\nU 14 (#057df1)\r\nR 4 (#00fb80)\r\nU 5 (#6af571)\r\nR 6 (#07a410)\r\nU 3 (#3c1ee1)\r\nR 2 (#32f0f0)\r\nU 11 (#03ddc1)\r\nR 4 (#484e32)\r\nD 11 (#3bc131)\r\nR 2 (#154652)\r\nD 3 (#b77fd1)\r\nR 3 (#4a1ac2)\r\nD 4 (#135613)\r\nR 5 (#36a092)\r\nD 5 (#ab8143)\r\nL 13 (#021482)\r\nD 5 (#3469b3)\r\nL 3 (#5e8c32)\r\nD 4 (#3e42a1)\r\nR 7 (#86bcf2)\r\nU 6 (#5ddf73)\r\nR 5 (#164fa2)\r\nD 6 (#33fcc3)\r\nR 4 (#aee5e2)\r\nD 4 (#33fcc1)\r\nL 5 (#35c742)\r\nD 12 (#5ddf71)\r\nR 4 (#60be02)\r\nD 3 (#3e42a3)\r\nR 9 (#4a1df2)\r\nU 8 (#824c83)\r\nL 4 (#942f82)\r\nU 5 (#824c81)\r\nR 5 (#0458c2)\r\nU 6 (#533f91)\r\nL 5 (#576bd0)\r\nU 6 (#175183)\r\nR 4 (#128280)\r\nU 3 (#175181)\r\nR 9 (#62e7f0)\r\nU 5 (#4de9e1)\r\nR 5 (#3ac090)\r\nD 5 (#6899c1)\r\nR 5 (#606550)\r\nD 9 (#6899c3)\r\nR 9 (#405a40)\r\nD 2 (#27a6a1)\r\nR 4 (#1e2620)\r\nD 5 (#5919c1)\r\nR 4 (#4fc360)\r\nU 8 (#74c2d1)\r\nR 6 (#4c81f2)\r\nD 4 (#65b0e1)\r\nR 4 (#22f362)\r\nD 12 (#496fc1)\r\nR 6 (#7a8152)\r\nU 3 (#5b71a1)\r\nR 6 (#2c6cc2)\r\nU 3 (#7e8be3)\r\nR 4 (#1d9842)\r\nU 7 (#89ce03)\r\nL 10 (#59bda2)\r\nU 3 (#023863)\r\nR 4 (#7e99c2)\r\nU 5 (#0758f1)\r\nL 3 (#09ece2)\r\nU 10 (#30fb21)\r\nL 8 (#471bd0)\r\nD 4 (#58ab01)\r\nL 2 (#471bd2)\r\nD 6 (#387a31)\r\nL 7 (#0c1ff2)\r\nU 8 (#116623)\r\nR 4 (#721752)\r\nU 7 (#9fe473)\r\nR 7 (#28d322)\r\nU 4 (#359c13)\r\nR 2 (#0e0c22)\r\nU 6 (#085061)\r\nR 12 (#63e0e2)\r\nD 5 (#b3e741)\r\nR 5 (#4612f2)\r\nD 3 (#1948e1)\r\nR 3 (#23fe72)\r\nD 3 (#116621)\r\nR 5 (#1814b2)\r\nD 9 (#5171c1)\r\nR 3 (#148182)\r\nU 9 (#453cf1)\r\nR 7 (#4afe40)\r\nD 4 (#3b5fb1)\r\nR 3 (#9cbb00)\r\nD 7 (#63d411)\r\nR 7 (#017970)\r\nD 4 (#3020d1)\r\nR 3 (#131310)\r\nD 6 (#197ac1)\r\nR 7 (#3e1090)\r\nD 8 (#679641)\r\nL 7 (#630702)\r\nD 10 (#62dc11)\r\nR 5 (#7bf202)\r\nD 5 (#242911)\r\nL 7 (#4cd470)\r\nD 8 (#76a031)\r\nL 3 (#6d3460)\r\nD 10 (#76a033)\r\nL 2 (#24f030)\r\nD 10 (#59a2e1)\r\nL 8 (#317750)\r\nD 2 (#5af153)\r\nL 4 (#6047b0)\r\nD 7 (#31bd23)\r\nL 11 (#62d9f0)\r\nD 6 (#13e781)\r\nL 5 (#90e050)\r\nD 11 (#13e783)\r\nL 3 (#5e0080)\r\nD 7 (#45c443)\r\nL 4 (#96cc12)\r\nD 3 (#00a151)\r\nL 2 (#87a1b2)\r\nD 9 (#00a153)\r\nL 6 (#334d02)\r\nD 5 (#4ee7e3)\r\nL 2 (#6cd090)\r\nD 10 (#405e73)\r\nL 4 (#514540)\r\nU 4 (#391461)\r\nL 3 (#6ff4a0)\r\nU 7 (#217213)\r\nL 7 (#67c592)\r\nU 4 (#4453e3)\r\nL 2 (#03e282)\r\nU 6 (#81c463)\r\nL 7 (#6ba810)\r\nU 7 (#6da1f3)\r\nL 9 (#a21980)\r\nU 5 (#29a6a1)\r\nL 4 (#22f180)\r\nU 7 (#6c8c21)\r\nL 6 (#371212)\r\nU 5 (#13a9b1)\r\nL 3 (#8bac52)\r\nD 6 (#084a91)\r\nL 5 (#500bd0)\r\nD 10 (#637be1)\r\nL 8 (#434e90)\r\nD 4 (#2a8011)\r\nR 3 (#2f6400)\r\nD 4 (#150951)\r\nR 4 (#4478e0)\r\nD 9 (#0afe21)\r\nR 6 (#08c250)\r\nD 2 (#b821f1)\r\nR 5 (#08c252)\r\nD 3 (#174461)\r\nL 6 (#372d02)\r\nD 5 (#7a0601)\r\nL 2 (#6f3752)\r\nD 2 (#17c891)\r\nL 10 (#236a02)\r\nD 3 (#17c893)\r\nL 5 (#87fe42)\r\nD 3 (#7a0603)\r\nR 2 (#27abf2)\r\nD 10 (#843cc1)\r\nR 5 (#5d38c2)\r\nD 5 (#02fce1)\r\nR 8 (#0fead2)\r\nD 7 (#8321d1)\r\nR 6 (#0fead0)\r\nD 5 (#4c9a81)\r\nR 5 (#2363e2)\r\nD 6 (#4e0821)\r\nL 10 (#369e92)\r\nD 4 (#40e7e3)\r\nL 9 (#6159a2)\r\nD 6 (#257ff1)\r\nL 7 (#5120a2)\r\nD 7 (#8d2261)\r\nL 6 (#66afe2)\r\nD 2 (#613283)\r\nL 6 (#0a8e52)\r\nD 7 (#516fd3)\r\nL 8 (#5a9cb2)\r\nD 6 (#2eb203)\r\nL 3 (#224c30)\r\nU 15 (#7df713)\r\nL 2 (#224c32)\r\nU 5 (#0f67a3)\r\nL 8 (#239eb2)\r\nD 9 (#23c8c3)\r\nR 6 (#30fc22)\r\nD 6 (#08a811)\r\nL 6 (#392a42)\r\nD 5 (#4f78d1)\r\nL 7 (#65ee62)\r\nD 7 (#4e3ea1)\r\nL 3 (#183cf2)\r\nD 5 (#67fa21)\r\nL 3 (#743c22)\r\nD 8 (#5a3161)\r\nL 3 (#77ded2)\r\nD 3 (#91f671)\r\nL 9 (#06c862)\r\nD 3 (#034a71)\r\nL 6 (#0051d2)\r\nD 7 (#5f7e11)\r\nL 6 (#3bbe82)\r\nD 5 (#4e2051)\r\nL 3 (#703282)\r\nD 7 (#55a831)\r\nL 11 (#6722d2)\r\nD 3 (#927f03)\r\nL 7 (#496570)\r\nD 4 (#090683)\r\nL 10 (#28b120)\r\nD 5 (#a86aa3)\r\nL 8 (#28b122)\r\nD 8 (#1608e3)\r\nL 5 (#496572)\r\nD 13 (#98bfd3)\r\nR 4 (#087c02)\r\nU 2 (#133d71)\r\nR 4 (#2dc4c2)\r\nU 11 (#433e51)\r\nR 6 (#2a9990)\r\nU 5 (#465031)\r\nR 6 (#2a9992)\r\nD 10 (#6138e1)\r\nR 3 (#43ecd2)\r\nD 8 (#525613)\r\nR 7 (#568082)\r\nD 4 (#38a9c3)\r\nL 4 (#816912)\r\nD 4 (#3524d3)\r\nL 11 (#050512)\r\nD 3 (#14e663)\r\nR 6 (#7eb6d0)\r\nD 9 (#735743)\r\nR 2 (#154b80)\r\nD 3 (#278d53)\r\nR 7 (#48ec50)\r\nD 4 (#6f0473)\r\nL 8 (#00d392)\r\nD 5 (#4a75e1)\r\nL 7 (#320322)\r\nD 3 (#144501)\r\nL 5 (#8c2db2)\r\nU 8 (#144503)\r\nL 10 (#463122)\r\nU 5 (#32a6b1)\r\nL 6 (#258b30)\r\nU 5 (#880b81)\r\nR 12 (#13e0c2)\r\nU 4 (#3f3e61)\r\nR 4 (#7047f2)\r\nU 5 (#519041)\r\nL 4 (#81d622)\r\nU 4 (#100251)\r\nL 7 (#29e330)\r\nD 6 (#0c1811)\r\nL 3 (#ab8d80)\r\nU 7 (#0c1813)\r\nL 4 (#308e20)\r\nU 6 (#2a2161)\r\nL 5 (#258b32)\r\nU 6 (#136f11)\r\nL 9 (#5843f2)\r\nU 5 (#175f81)\r\nL 3 (#643e12)\r\nU 7 (#5739b1)\r\nL 3 (#6b3102)\r\nU 3 (#a48961)\r\nR 7 (#342652)\r\nU 2 (#605c83)\r\nR 12 (#034b90)\r\nU 3 (#6c7f23)\r\nR 5 (#034b92)\r\nU 4 (#2ee773)\r\nL 4 (#1c9582)\r\nU 4 (#2fdd61)\r\nL 3 (#562392)\r\nU 8 (#2825c1)\r\nL 4 (#112402)\r\nU 6 (#4c03c1)\r\nL 8 (#485412)\r\nD 4 (#4ce6d3)\r\nL 2 (#6cd332)\r\nD 14 (#4ce6d1)\r\nL 3 (#070f52)\r\nU 3 (#61ece3)\r\nL 5 (#045ee2)\r\nU 3 (#123ca3)\r\nL 7 (#3f36c2)\r\nU 10 (#a9aca3)\r\nL 4 (#709942)\r\nU 2 (#6c2da3)\r\nL 4 (#304322)\r\nD 4 (#05f8a3)\r\nL 6 (#5054e2)\r\nD 4 (#b5c263)\r\nL 10 (#50c322)\r\nU 5 (#593113)\r\nL 3 (#4b0a12)\r\nU 3 (#5475a3)\r\nL 5 (#8bd8c2)\r\nU 9 (#1e9373)\r\nL 3 (#1752b2)\r\nU 4 (#74e433)\r\nL 3 (#1bb2b2)\r\nU 7 (#446ae3)\r\nL 8 (#729ce0)\r\nU 10 (#466cb1)\r\nL 2 (#6efdd0)\r\nD 10 (#466cb3)\r\nL 9 (#11f210)\r\nU 6 (#141693)\r\nL 8 (#52f450)\r\nU 7 (#7a3e33)\r\nR 8 (#3fa620)\r\nU 7 (#1ee3e3)\r\nR 11 (#4fe1a0)\r\nD 7 (#1e21e3)\r\nR 7 (#868012)\r\nD 6 (#917853)\r\nR 3 (#868010)\r\nD 4 (#5064f3)\r\nR 8 (#603410)\r\nU 4 (#1a07e3)\r\nR 7 (#370950)\r\nU 6 (#764a93)\r\nR 5 (#6ed900)\r\nD 4 (#64b8c3)\r\nR 5 (#9bfd10)\r\nD 14 (#38b1c3)\r\nR 3 (#1229b0)\r\nD 9 (#52db43)\r\nR 8 (#1ccf60)\r\nU 8 (#629983)\r\nR 5 (#10d560)\r\nU 2 (#26f753)\r\nR 9 (#72db50)\r\nU 4 (#11ca51)\r\nL 10 (#01afd0)\r\nU 5 (#412043)\r\nL 4 (#11b470)\r\nU 4 (#4165a3)\r\nR 3 (#a04090)\r\nU 4 (#4165a1)\r\nR 9 (#0b6860)\r\nU 9 (#412041)\r\nL 3 (#0670d0)\r\nU 9 (#11ca53)\r\nL 3 (#11d720)\r\nU 4 (#26f751)\r\nL 11 (#28d6a0)\r\nD 4 (#629981)\r\nL 9 (#1c3f30)\r\nD 9 (#2577b3)\r\nL 4 (#a6a900)\r\nU 3 (#5206f3)\r\nL 4 (#a6a902)\r\nD 3 (#5cfad3)\r\nL 6 (#4e2420)\r\nD 9 (#007143)\r\nL 5 (#397670)\r\nU 5 (#0b5db3)\r\nL 3 (#61c920)\r\nU 7 (#50d8b3)\r\nL 5 (#2192c2)\r\nU 7 (#6c1ab3)";

        private List<Dictionary<int, char>> CentreGrid(Dictionary<int, Dictionary<int, char>> grid, int minGridYKey, int minGridXKey)
        {
            var grid2 = new List<Dictionary<int, char>>();

            for (var i = 0; i < grid.Count; i++)
            {
                var row = grid[i + minGridYKey];
                grid2.Add(new Dictionary<int, char>());
                foreach (var (key, item) in row)
                {
                    grid2[i].Add(key - minGridXKey, item);
                }
            }

            return grid2;
        }

        private List<Dictionary<int, char>> FillGrid(int largestKey, List<Dictionary<int, char>> grid2)
        {
            //var grid3 = new List<Dictionary<int, char>>();
            var grid = new ConcurrentDictionary<int, Dictionary<int, char>>();
            // a pixel is inside the shape if it hits an odd number
            // of walls in any direction. We picked right. A horizontal
            // section counts as a single wall (so ### ### is 2 walls, not 6)
            Parallel.For(0, grid2.Count, i =>
            {
                //for (var i = 0; i < grid2.Count; i++)
                //{
                var z = new Dictionary<int, char>();
                for (var j = 0; j < largestKey; j++)
                {
                    if (grid2[i].ContainsKey(j))
                    {
                        z[j] = grid2[i][j];
                        continue;
                    }
                    var hashesToRight = 0;

                    for (var x = j; x < largestKey; x++)
                    {
                        if (grid2[i].ContainsKey(x))
                        {
                            if (!(i > 0 && grid2[i - 1].ContainsKey(x)
                                && i < grid2.Count - 1 && grid2[i + 1].ContainsKey(x)))
                            {
                                var isBelow = false;
                                if (i > 0 && grid2[i - 1].ContainsKey(x))
                                {
                                    isBelow = true;
                                }

                                while (grid2[i].ContainsKey(x + 1))
                                {
                                    x++;
                                }

                                if ((i > 0 && isBelow && grid2[i - 1].ContainsKey(x))
                                    || (i < grid2.Count - 1 && !isBelow && grid2[i + 1].ContainsKey(x)))
                                {
                                    continue;
                                }
                            }

                            hashesToRight++;
                        }
                    }
                    if (hashesToRight % 2 != 0)
                    {
                        z[j] = '#';
                    }
                }

                grid[i] = z;
                //}
            });
            return grid.OrderBy(x => x.Key)
                .Select(x => x.Value)
                .ToList();
        }

        private Dictionary<int, Dictionary<int, char>> BuildGrid(IEnumerable<string> lines)
        {
            var currentX = 0;
            var currentY = 0;

            var grid = new Dictionary<int, Dictionary<int, char>> { { 0, new Dictionary<int, char>() } };
            foreach (var line in lines)
            {
                var s = line.Split(' ');
                var direction = s[0];
                var length = int.Parse(s[1]);


                switch (direction)
                {
                    case "U":
                        for (var i = 1; i <= length; i++)
                        {
                            if (!grid.ContainsKey(currentY - i))
                            {
                                grid[currentY - i] = new Dictionary<int, char>();
                            }
                            grid[currentY - i][currentX] = '#';
                        }
                        currentY -= (length);
                        break;

                    case "D":
                        for (var i = 1; i <= length; i++)
                        {
                            if (!grid.ContainsKey(currentY + i))
                            {
                                grid[currentY + i] = new Dictionary<int, char>();
                            }
                            grid[currentY + i][currentX] = '#';
                        }

                        currentY += length;
                        break;

                    case "L":
                        for (var i = 1; i <= length; i++)
                        {
                            grid[currentY][currentX - i] = '#';
                        }
                        currentX -= (length);
                        break;

                    case "R":
                        for (var i = 1; i <= length; i++)
                        {
                            grid[currentY][currentX + i] = '#';
                        }
                        currentX += length;
                        break;

                    default: throw new Exception();
                }
            }

            return grid;
        }

        public void Part1()
        {
            //_input = "R 6 (#70c710)\r\nD 5 (#0dc571)\r\nL 2 (#5713f0)\r\nD 2 (#d2c081)\r\nR 2 (#59c680)\r\nD 2 (#411b91)\r\nL 5 (#8ceee2)\r\nU 2 (#caa173)\r\nL 1 (#1b58a2)\r\nU 2 (#caa171)\r\nR 2 (#7807d2)\r\nU 3 (#a77fa3)\r\nL 2 (#015232)\r\nU 2 (#7a21e3)";

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var grid = BuildGrid(lines);
            var largestKey = grid.SelectMany(x => x.Value.Keys).Max() + 1;

            var minGridYKey = grid.Keys.Min();
            var minGridXKey = grid.Values.SelectMany(x => x.Keys).Min();
            var width = largestKey - minGridYKey;
            var grid2 = CentreGrid(grid, minGridYKey, minGridXKey);
            var grid3 = FillGrid(width, grid2);
            //var grid3 = grid2;
            //for (var i = 0; i < grid3.Count; i++)
            //{
            //    for (var j = 0; j < width; j++)
            //    {
            //        Console.Write(grid3[i].ContainsKey(j) ? '#' : '.');

            //    }
            //    Console.Write('\n');
            //}

            Console.WriteLine(grid3.SelectMany(x => x.Values).Where(x => x == '#').Count());
            //Console.WriteLine(grid3.SelectMany(x => x.Value.Values).Count());
        }

        private string ConvertLineToInstruction(string line)
        {
            var hex = line.Split(' ')[2].Substring(2, 6);

            var distance = int.Parse(hex.Substring(0, 5), System.Globalization.NumberStyles.HexNumber);
            var direction = hex.Substring(5) switch
            {
                "0" => 'R',
                "1" => 'D',
                "2" => 'L',
                "3" => 'U',
                _ => throw new Exception(),
            };

            return $"{direction} {distance}";
        }

        private IEnumerable<string> ConvertLinesToInstructions(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                yield return ConvertLineToInstruction(line);
            }
        }

        public void Part2()
        {
            _input = "R 6 (#70c710)\r\nD 5 (#0dc571)\r\nL 2 (#5713f0)\r\nD 2 (#d2c081)\r\nR 2 (#59c680)\r\nD 2 (#411b91)\r\nL 5 (#8ceee2)\r\nU 2 (#caa173)\r\nL 1 (#1b58a2)\r\nU 2 (#caa171)\r\nR 2 (#7807d2)\r\nU 3 (#a77fa3)\r\nL 2 (#015232)\r\nU 2 (#7a21e3)";

            var lines = _input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var grid = BuildGrid(ConvertLinesToInstructions(lines));

            var largestKey = grid.SelectMany(x => x.Value.Keys).Max() + 1;

            var minGridYKey = grid.Keys.Min();
            var minGridXKey = grid.Values.SelectMany(x => x.Keys).Min();
            var width = largestKey - minGridYKey;
            var grid2 = CentreGrid(grid, minGridYKey, minGridXKey);
            //var grid3 = FillGrid(width, grid2);
            var grid3 = grid2;

            //using (var f = new StreamWriter("D:\\Temp\\aoC18Out.txt"))
            //{
            //    for (var i = 0; i < grid3.Count; i++)
            //    {
            //        for (var j = 0; j < width; j++)
            //        {
            //            f.Write(grid3[i].ContainsKey(j) ? '#' : '.');

            //        }
            //        f.Write('\n');
            //    }
            //}
                
            Console.WriteLine(grid3.SelectMany(x => x.Values).Where(x => x == '#').LongCount());
        }
    }
}
