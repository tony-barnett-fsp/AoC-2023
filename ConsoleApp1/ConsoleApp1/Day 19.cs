using System.Diagnostics;

internal class Day19
{
    private string _input = "vvd{a<3062:hrj,x>1762:zgl,s<881:dlf,A}\r\nckk{s>862:R,a>3127:A,A}\r\nth{a<3804:jjp,a>3923:mfp,a<3866:ck,fgv}\r\nsm{m>453:A,s<2996:R,A}\r\ngj{x>1334:R,R}\r\nszs{m>3306:A,a<2977:A,A}\r\nhk{m<2759:tbr,s>3402:A,cn}\r\nhrj{s>993:R,R}\r\ngd{m<1654:pb,zk}\r\nzb{x>2892:R,R}\r\nqd{x>926:R,s>1347:A,s<1075:R,R}\r\ngb{a<3731:tt,x<2259:tdk,qxg}\r\nnh{a>1660:A,a<1559:A,A}\r\nqb{x<952:A,a<824:R,A}\r\nhb{x>958:R,R}\r\ntl{s>3339:glg,m>3104:R,bx}\r\ndv{a<3358:A,A}\r\nkgt{a<2746:R,s<590:A,x<961:R,A}\r\nfgv{m>1968:R,pcs}\r\nkzc{x>1543:R,x<1255:lrn,lb}\r\npz{m>3096:R,A}\r\nfbq{m<3544:fq,sdh}\r\nvp{m>1213:qgj,a>2889:dn,m>629:A,tk}\r\ncpv{s<1222:R,a<3006:A,m>485:R,R}\r\ncm{s>1201:vbl,x>1442:lv,ff}\r\nms{x>1035:R,A}\r\nnqf{a>3776:A,x<2712:R,A}\r\ntns{m<512:A,R}\r\nddj{x<982:A,R}\r\nlkm{s>1761:A,x<3406:R,A}\r\nrgv{x<1838:R,A}\r\nkk{a<3285:A,m>3883:A,a>3614:A,R}\r\nsb{a<2998:A,x>1425:R,m>399:A,A}\r\npsn{s<2782:R,a<2995:R,A}\r\nxn{s>2939:slq,m>2356:fgs,rj}\r\nflx{m>502:A,x<3413:A,s>1324:A,A}\r\nhqb{a>2426:tx,s<3349:A,R}\r\ntq{m>1617:dvq,x<2295:jsh,a<3368:rzc,qms}\r\ncn{s>3099:R,A}\r\nlft{m>726:R,m>598:A,R}\r\nkt{a<2349:tdv,x>1126:hnz,bps}\r\nqms{m<1499:lvq,a>3479:R,R}\r\nns{s>1283:R,A}\r\ncj{m>3441:ql,m<3391:A,R}\r\nrcm{x<1000:R,lrz}\r\ntqd{x>1200:A,A}\r\nlkc{m<1761:A,A}\r\ngzf{x<3613:A,a>2771:R,A}\r\nnzt{a>306:A,s<973:R,A}\r\nfth{m>355:R,s<3285:R,A}\r\ncmg{a>3790:R,m>1001:R,A}\r\nvhf{s>1126:A,a<3520:tsb,R}\r\nmpm{m>869:qh,a>3099:zq,dff}\r\nlq{x<2632:zpc,tct}\r\ndlf{m>1614:R,m<1126:A,A}\r\nbkk{s<3105:mqs,sg}\r\ntct{s<984:gnm,m>1073:jfz,s>1514:dc,xj}\r\nlv{a<239:A,A}\r\nfb{m>2007:R,A}\r\nfpj{s<1828:xz,zt}\r\nkl{s>2400:A,x>1193:A,x<671:A,A}\r\njb{s>796:qt,zn}\r\nqs{x>2260:A,a<3886:jxg,a<3903:pt,A}\r\ntc{a>2840:rqp,m>1035:vl,hq}\r\nfss{s>1221:fld,m>1250:hvc,rg}\r\nqkd{x<3277:A,R}\r\nscm{a>3604:A,x>2828:gtl,s<3136:nn,R}\r\nlxd{x>1459:R,s<2218:R,m<1488:A,R}\r\nqvl{a>2241:zsv,a>2125:R,R}\r\nttb{x<1466:bfr,R}\r\nzbk{m<464:A,s<3379:R,R}\r\nxv{s>494:A,R}\r\npld{m<2671:R,a>3092:R,A}\r\nzjm{a<3448:A,A}\r\npd{s<2953:rm,szc}\r\ntfn{s<719:dh,m>343:bgz,bn}\r\nktl{s<2776:dp,s>3093:mfv,a>2897:fm,pd}\r\npnh{a<239:A,x<3185:R,R}\r\nrrc{m>1995:A,s<1027:A,A}\r\nnzp{s<2226:A,a>2676:A,A}\r\ntzf{a<3801:A,m>841:cgp,R}\r\nzp{m>158:A,A}\r\npr{x>2833:txv,x<2596:jf,a<3047:fj,np}\r\nrjl{a<2122:R,m<1656:R,m>1865:R,A}\r\nzx{x<1497:A,A}\r\nvtf{m<1214:R,R}\r\ntzk{x<3013:R,s<3078:ss,s>3545:tb,tpm}\r\nffj{x>1221:R,A}\r\ntkx{a<2272:R,x>915:R,A}\r\ndg{a<3554:A,m<929:vsm,hqx}\r\nlf{s<1049:R,R}\r\nkpz{a<2829:dsg,m<3108:R,m<3701:bp,kk}\r\nqf{s<635:jd,a>1648:qmt,fd}\r\ngsn{s<3722:A,s>3839:km,vqb}\r\ntxv{m<3809:A,R}\r\njrm{a<292:R,m<840:R,x<3311:A,R}\r\nzbg{a>538:A,m>1824:pnh,jrm}\r\nlmk{s<809:A,a<3296:R,A}\r\nrv{s<2680:A,s>2808:sr,x<1735:hhm,R}\r\nxc{m<2865:xn,bd}\r\ndzj{s>1477:R,x<2248:A,a<3592:R,flx}\r\nzpc{a>608:pv,x<934:sx,m<1037:cl,dj}\r\npvz{a>2770:A,A}\r\ngr{a>462:R,m<2929:A,A}\r\nzq{x<1166:tfn,m<571:fjm,s<1013:jss,qx}\r\nkp{s>355:md,m<2930:cc,nj}\r\njz{x<987:gzx,rl}\r\npp{x<3704:A,s>3206:R,m<3115:A,A}\r\nbcn{s>2021:A,m<1423:A,R}\r\nqtk{x<1430:R,x<2500:A,A}\r\nvsm{x<2477:R,R}\r\nvmb{m<1207:tns,jrn}\r\nlvq{s<810:A,s<1122:A,s<1245:A,A}\r\nkhs{x>2121:xvq,A}\r\nngj{s<399:R,A}\r\nss{s>2610:A,x>3640:R,s>2396:R,A}\r\nkbz{x<1704:A,a>3333:R,a<3253:A,A}\r\nmks{x<3622:A,x<3764:R,a>3793:A,A}\r\nmx{a>1771:A,R}\r\nnf{a<1730:R,x<3361:R,s>1633:A,A}\r\nsx{s<1067:R,x<583:bm,x<742:mcm,A}\r\ngjk{a>2935:A,x>3630:A,s>1501:R,R}\r\ngk{x>1901:pcd,s>1977:fpf,lqr}\r\nhz{s>2381:R,s<2154:A,R}\r\nnht{s>1162:A,m>558:R,x>2991:A,R}\r\npll{m>1200:sgn,x>395:phg,a>2429:xd,A}\r\nbj{x<1510:ks,s<729:jlm,gfx}\r\nxr{m>488:R,A}\r\ntfh{m>864:R,m<433:R,m>662:A,A}\r\nhfd{x<3738:R,R}\r\ncjt{a<2997:A,s<1260:tvq,m>1403:xm,R}\r\nkb{s<1000:A,s>1542:A,A}\r\nlsf{x>1237:fqk,A}\r\nmmv{x>3617:R,s<1009:mq,ns}\r\nbfr{x>951:A,s>1265:A,R}\r\npb{a<1607:zgf,kg}\r\njts{a>2338:vsj,x>1160:A,a>2097:zp,A}\r\nzmz{x<1333:R,a>2919:R,a<2898:R,A}\r\nql{s<2765:A,s>3539:R,a>2246:R,R}\r\nfqz{m>313:dl,R}\r\nbdt{m<2707:pld,lrr}\r\nvrj{a>3214:scm,zv}\r\nhkq{s>2374:sz,A}\r\nlp{s<1125:thr,sfr}\r\nkbh{s>3110:jcg,s>2776:R,m<1890:A,R}\r\ntk{x>916:A,x<350:A,R}\r\nxkq{a>3056:R,psn}\r\nsgz{a>579:A,x>2261:pc,m>3185:kzq,A}\r\nvd{x<3081:fsx,s>2036:dth,gkg}\r\nsr{s>2908:A,x>2436:A,x>1169:R,A}\r\nzm{m<3770:gzf,m>3888:R,nvh}\r\nkcs{x<3636:pkt,a<2781:hlg,x>3835:xsj,xr}\r\ntg{s>2776:R,R}\r\ndp{a>2961:R,A}\r\ngh{a<2396:R,m>972:R,x>3211:gpb,xp}\r\nsk{m<1280:A,A}\r\nbc{x<2841:A,a>1557:A,s<385:R,R}\r\nthf{a>3106:A,x>3631:A,s>1037:A,A}\r\nnn{m<2491:A,R}\r\nvhc{a<3571:nmk,rjb}\r\npcz{s<275:R,a>2784:R,A}\r\njgv{x<1067:vhf,lp}\r\nvvf{a>2403:R,R}\r\njsh{a>3401:A,A}\r\nvbp{x<2776:R,s>3492:R,m<2655:R,A}\r\nctl{m>1709:R,x>1436:R,a>3348:R,R}\r\nxrb{a<2649:R,x<934:A,A}\r\ngs{m>2043:A,x<3011:R,x>3230:R,R}\r\nrg{s<670:A,s<957:R,A}\r\nbl{s<1524:vx,s>1654:A,s<1601:A,nf}\r\ngfx{a<3594:A,s<974:R,A}\r\nkxl{s<1519:R,s>1562:R,A}\r\nds{a<3168:A,A}\r\nfcp{s<2341:R,m>297:R,A}\r\nglb{s<2066:R,a<3736:A,a<3870:R,R}\r\nfvx{x>263:A,A}\r\nmt{s>625:R,a<1776:A,s<217:R,A}\r\nqzv{m>1080:R,A}\r\nthr{a<3487:A,s>505:R,a>3759:A,R}\r\ntsb{a<3152:A,m<2461:A,a<3391:R,R}\r\nfsm{m<561:R,a<2786:A,R}\r\njzs{a<3752:A,x<1950:xf,m<1782:R,fs}\r\nkxk{m<570:A,R}\r\nzv{a>2688:R,s>3118:vbp,R}\r\nxcp{m>644:R,s<2394:A,m<338:A,R}\r\nlt{a>3140:ds,thf}\r\ncxt{a<3625:scz,tzf}\r\nqp{a>2830:zz,m>1424:zbp,sk}\r\nvb{s<3582:A,s>3789:R,A}\r\nrh{x>799:R,s>3176:A,R}\r\nhzq{x<2680:R,A}\r\njmm{s<1119:bj,m<680:pq,x>1590:dkd,bgc}\r\nvtg{s>3299:gj,s>2431:zx,A}\r\ndfq{s>1634:lkm,a>3475:mks,kxl}\r\ndcr{s>1739:A,A}\r\nbnn{a<207:R,x>446:A,m>3421:xdp,gr}\r\nhqx{a>3731:A,R}\r\nxd{s<3275:A,a<2588:R,m>437:R,R}\r\ndth{m<702:fqz,xtr}\r\nvnj{a>3383:A,m<1784:A,s>1539:R,R}\r\ndl{a>2976:A,s<3191:R,A}\r\nfv{x<3335:vrj,qkm}\r\npg{x<1444:R,m>2004:R,A}\r\nck{m>1984:kcq,m>1942:qtk,R}\r\nzz{m<1305:R,A}\r\npbc{m>226:A,s<1134:R,A}\r\nkx{m>1355:vhc,gn}\r\ngrr{m>2230:lzz,x<3328:A,s<1205:hc,cr}\r\nnj{x>1430:R,s>185:A,A}\r\nltb{a>597:tj,x>970:cm,bnn}\r\nqnn{x>3342:R,x>2644:R,R}\r\nmfp{s>1123:R,m>1993:ft,R}\r\nzgf{s>2601:A,m<973:A,tzx}\r\nnvh{a>2945:A,R}\r\nqxg{x>2968:xcp,A}\r\nbn{m<149:R,x>731:R,A}\r\ndqk{s>1560:R,s>534:A,A}\r\nmg{s>2297:rv,pgf}\r\nqt{s>1334:A,s<1018:R,R}\r\nhc{s>459:R,m<812:R,a>1440:R,A}\r\nfld{x>3004:R,A}\r\njd{x>2634:bc,s>234:R,a>1560:A,A}\r\nndr{m<1486:R,s>1539:dcr,R}\r\njvl{a<3475:A,s>2038:A,A}\r\ndkd{x<3070:dg,s>1405:dfq,lfp}\r\nsg{m>1909:A,x<914:R,m<1778:R,R}\r\nkhh{x<1396:R,a>3708:A,s>383:R,R}\r\nmb{s>1878:ftc,kpz}\r\nin{a<1965:fpj,m>2060:vh,a<3206:pdl,kx}\r\ngn{s>1904:qkj,jmm}\r\ngnm{x<3102:A,m<1222:kjn,gp}\r\nps{m>1681:hg,s>2179:qp,m<1433:fss,sd}\r\nzn{a<975:A,a>1069:A,x<3304:R,R}\r\nhhm{m>1630:A,m>617:A,m>333:A,A}\r\ngz{x<1706:A,s<2485:R,R}\r\nzpx{m>725:zss,xkq}\r\nfsx{s>2295:skb,bkr}\r\nscz{s<3285:dv,A}\r\njsj{x<3085:A,x<3686:R,A}\r\nxsj{a<2827:R,x>3904:A,A}\r\ngzq{m>810:A,a>827:R,s<3297:R,A}\r\nbb{x<2959:A,dz}\r\nvbl{m>2965:R,A}\r\ndmt{m>1732:hd,s>2127:R,jvl}\r\nlrn{x>1164:R,R}\r\nsmp{x>3224:R,s>1268:A,m<2046:A,A}\r\npc{s>693:A,A}\r\nkpx{m>1878:A,m>1807:R,x>928:R,R}\r\nglj{a>1711:R,a>1631:A,A}\r\nqk{m>1185:R,xrb}\r\nbdp{a<2516:lsf,a<2625:xk,a<2678:qk,tfh}\r\nczn{a<2241:fxp,x>3789:R,s<3133:rsm,A}\r\nks{x<999:xv,x>1311:khh,R}\r\nbkr{x<2429:mc,m<484:A,m<850:lft,R}\r\nbrl{s>1349:xg,gh}\r\nbx{x>1197:A,a>1427:R,s<3095:A,A}\r\nfhz{a>2435:A,m>3386:A,A}\r\nrl{a<3051:nsq,R}\r\ntr{s>1784:A,s>1693:A,m>190:A,A}\r\nmkj{x<1486:A,m>3363:A,a>1667:R,A}\r\nnb{a>1464:R,a>1365:jth,R}\r\nkzq{m>3512:R,A}\r\nkz{x>553:R,m>1531:A,m>1423:A,A}\r\ngl{a<2776:kgt,R}\r\nxpt{m<249:R,m>335:A,a>3718:A,R}\r\nzbp{a>2789:A,m<1574:A,s>3020:R,A}\r\nmfv{a>3208:A,x<1280:fhz,rf}\r\nqpn{x>3117:A,s<1302:A,a>2683:fjl,xnt}\r\nqm{a<2927:ps,tn}\r\npt{a<3892:R,a<3898:R,R}\r\nhks{x>2521:A,s<483:R,A}\r\nmd{x<1323:R,R}\r\njct{x>1059:gpl,a<2740:qv,mj}\r\nbt{m<1666:R,s>1464:A,m>1696:R,R}\r\ndsg{x<3064:A,A}\r\nnsk{x>3173:R,spq}\r\nqr{m>521:R,s>377:R,R}\r\nqqq{x<378:fg,m>2497:R,A}\r\ntj{a<935:jj,m>3383:A,a>1076:R,R}\r\nglg{a<1551:A,m>3175:R,R}\r\ncc{x<939:R,s<224:A,R}\r\nrk{s<1079:A,x<2703:A,A}\r\ndc{x<3243:R,a>568:R,jc}\r\nbcp{x>686:hqb,pll}\r\npft{m<912:vnn,dm}\r\nkfr{s>3103:nsk,x>3254:zm,pr}\r\nxvq{a>3436:A,m<1515:A,m<1586:R,R}\r\nbd{s<3314:ktl,jz}\r\nkm{s<3941:A,m<418:R,A}\r\nsj{s>3320:R,m<735:A,R}\r\njrn{m>1587:R,A}\r\ntx{a<2594:R,m<987:R,R}\r\ndj{m>1535:rrc,x<1518:xh,R}\r\nzgl{s>843:R,a>3152:R,m>1357:A,A}\r\nmfq{m>378:R,R}\r\nszc{s<3003:A,m<3402:R,m>3709:A,R}\r\nvnn{x<979:fdn,a<2498:A,a>2632:A,A}\r\nxkc{m>3553:kfr,pk}\r\nrzk{m>386:R,A}\r\ntbl{a<3119:A,m<1094:A,a>3172:A,A}\r\nsgn{s>3270:R,s<3159:R,x>306:R,A}\r\nkdh{x>1392:A,s<2174:gsg,m>2235:R,nzp}\r\nfg{x>157:A,x>87:R,A}\r\ndn{x>1120:R,A}\r\nzss{a<3072:A,s>3213:A,vtf}\r\ngsg{m>2239:A,x<588:R,a>2666:R,A}\r\njfz{m<1831:R,x>3533:jh,s>1453:gs,smp}\r\nphg{s>3312:R,m<723:R,m>941:R,A}\r\ncb{a>2536:A,s>812:pm,ngj}\r\nmf{m<1593:A,x<529:R,R}\r\nfhr{x>1106:R,x<386:A,x<798:kz,pcz}\r\nml{s<1370:R,R}\r\nzd{s>1589:A,a>1448:R,a>1311:A,lrh}\r\nxm{s<1627:R,a<3035:A,s<1799:R,A}\r\nsgs{x<3304:mt,x<3393:A,glj}\r\nttv{x>3479:nb,a<1580:grr,s<1026:sgs,bl}\r\nxp{x>3128:R,a>2555:R,R}\r\njx{s<2054:A,A}\r\nbjd{s<818:A,R}\r\ntzx{a<1332:R,m<1279:A,a<1434:R,A}\r\nmj{s<2372:A,s>2416:R,A}\r\ndh{s<467:A,m<418:A,m>634:A,R}\r\nfj{x<2703:A,x<2772:R,m<3838:R,A}\r\njxg{x>909:A,s>2752:A,s<2236:R,A}\r\nbfs{m<1689:R,m>1872:A,A}\r\ndz{m>3210:A,x>3525:R,A}\r\nmcm{a>283:R,a>116:R,a>49:A,A}\r\ndqr{m<1356:ckk,s>1025:nmm,a<3125:ffj,A}\r\ntbr{m<2367:R,x<2937:R,A}\r\nrsm{x<3615:R,x>3713:R,m>909:A,R}\r\nrm{m<3439:R,A}\r\nfmb{s>2014:nr,a<2950:hm,mpm}\r\npq{m<400:knp,dzj}\r\nlsk{m<322:R,s>2264:R,R}\r\nzsv{m>713:R,R}\r\nmk{a<2676:R,R}\r\nknp{s>1623:tr,s<1355:xpt,ssk}\r\nbmv{a<3815:qnx,m<1902:vtg,a<3932:qs,dmk}\r\nhlg{a>2740:R,m>464:A,R}\r\npn{s>759:A,m>1519:R,A}\r\nqnx{x<1888:R,A}\r\nnmm{x<1288:R,s<1542:A,A}\r\nff{a<305:A,R}\r\nrt{m<1666:khs,x>1599:kbh,bkk}\r\nbgz{x<430:A,x<824:A,A}\r\nhm{a>2828:ksr,m>1357:mhl,rnt}\r\nfdn{x<359:R,A}\r\nhq{a<2800:fth,x>1082:A,s<2977:R,zbk}\r\nxh{a<267:R,m>1348:R,a<492:R,A}\r\nrf{a<2730:R,a<3039:R,R}\r\npl{m>2474:mkj,a<1456:A,nh}\r\nhrg{m<3582:A,x<1494:R,x>2002:R,A}\r\nkn{x<2826:sgz,a>638:jb,x<3390:ccz,mmv}\r\ncgp{m<1166:R,a>3899:R,x<1426:R,R}\r\nnvp{s>1649:A,s<765:mzn,zkb}\r\nskb{s>3129:R,s>2585:R,x>2580:zb,R}\r\nfs{s<971:A,s<1381:R,s<1589:A,A}\r\nfm{s<2965:A,s>3026:zjm,A}\r\nzvz{s>2991:bv,mg}\r\nfxp{m<759:A,R}\r\nmzn{s<436:R,x<2333:A,a>2292:A,A}\r\nhg{x>2695:rn,s>2386:R,x<2329:R,A}\r\nxf{a<3868:A,A}\r\ngx{a<2954:nnv,m>2815:fbq,jgv}\r\nnp{a>3593:A,m>3821:R,R}\r\nnct{m<1503:A,glb}\r\nmpl{s<1048:R,gjk}\r\ngpl{x>1584:R,s<2360:R,a<2875:R,A}\r\ndmk{a<3973:czg,s<3272:pg,A}\r\nlqr{a<2295:mnt,s>823:bdp,s>373:vmb,pft}\r\nsdh{s<743:R,a<3416:R,m<3797:fhq,tp}\r\nxg{m<1238:R,x>3346:A,m<1761:A,R}\r\nnss{s<3633:rh,A}\r\njth{x>3707:R,A}\r\nbv{x<2477:ljl,s>3516:zbg,gsq}\r\nct{a>3210:R,A}\r\nmh{m<3086:A,A}\r\ngnt{m>1076:R,R}\r\nmhl{m>1815:rcm,s>751:pvz,s>442:gl,fhr}\r\nfz{m>447:A,s>2628:A,m>293:A,R}\r\ngp{a>573:R,a<367:A,m<1733:A,R}\r\nqq{s>1754:czn,a<2335:qn,cb}\r\nksr{s<1161:vp,s<1671:kr,a<2871:rjj,lj}\r\njhs{a>3568:A,a>3361:R,R}\r\npgf{x<2090:R,m<1854:rqz,m<3102:R,qnn}\r\ndrk{m>2799:R,x>844:A,m<2423:R,A}\r\nlr{a<3110:A,x>3689:lxp,tg}\r\ntsf{x<906:A,s<3626:R,A}\r\nslq{x>1074:kzc,x<635:qqq,a<2692:nss,kj}\r\nxtr{m>851:R,m>780:sn,sj}\r\nsd{x>3112:lf,m<1593:pn,a>2806:mtv,A}\r\nmqs{s<2800:A,a<3429:A,a>3486:A,R}\r\ndm{a<2520:R,s>247:ms,x>887:fpz,A}\r\ntdk{s<2421:R,a<3901:R,A}\r\nqx{s>1541:R,nv}\r\nhd{a>3498:R,a>3424:A,R}\r\nfq{x<1299:jl,a<3628:A,A}\r\nqv{x<689:R,x>933:R,s<2373:R,A}\r\nnnv{a<2442:ttb,a>2628:kb,s<712:kp,zh}\r\nxdp{m<3623:R,m<3797:A,x>156:A,A}\r\nshr{m>595:bqs,m<393:R,qr}\r\npkt{s<1087:R,a<2786:R,x<3363:A,R}\r\nxz{a>1176:kdx,m>2309:fl,lq}\r\ntpm{m>3107:A,R}\r\nsh{s>2775:R,A}\r\npk{a>2798:bb,m>3345:cj,tzk}\r\ngkg{a>3040:lt,a<2878:kcs,m<499:bjd,mpl}\r\ncjc{s<623:A,s<1014:A,a>3256:A,R}\r\nkc{s>697:A,R}\r\nxnt{a>2374:R,x>2862:R,A}\r\nmtv{s<1181:R,A}\r\nftc{s>1991:A,mh}\r\nqgj{a<2874:A,A}\r\npcs{a>3897:A,s>903:R,R}\r\nspq{a>2688:A,s>3621:R,m<3800:R,R}\r\ncfh{a<2335:xrc,fql}\r\nlj{s<1815:zmz,R}\r\ndvq{m>1770:A,s>678:kbz,ctl}\r\ntn{m<1611:kjv,a>3081:ml,zxd}\r\nrxz{s>802:sb,R}\r\nnmk{s>2328:rt,s<1387:tq,hr}\r\nkjn{a<773:A,a<910:A,s<582:R,A}\r\nfh{m<317:jts,m<594:gsn,x<661:qvl,bq}\r\ntdv{m<1383:A,rjl}\r\njhr{a<2523:A,a<2728:R,A}\r\nbqs{s<416:R,s>574:R,a>2772:R,A}\r\nqnv{x>702:R,s<1521:kxk,R}\r\nfhq{s<1199:R,a>3693:R,R}\r\ndrc{s<3614:R,m<1189:R,a>2578:R,R}\r\nbs{x<2494:gx,njd}\r\nfjl{s>1410:A,R}\r\nqn{a>2138:R,m>1309:lkc,x>3708:A,R}\r\njj{x>921:R,s>1153:R,R}\r\npdl{a<2720:gk,x<2022:fmb,tm}\r\ngsq{a<574:qkd,x<3457:dbp,m>1541:pp,gzq}\r\ntp{x>1394:R,x>699:A,a>3692:R,A}\r\nqmt{a>1858:rk,s>1346:mx,s>1021:R,A}\r\nlnx{m>1720:kpx,s>2143:lxd,R}\r\nmnt{s<1107:hb,m>1084:ndr,qnv}\r\njlm{a>3607:nqf,s<268:mtx,hks}\r\nbq{x>1150:stt,m>747:A,tkx}\r\ntt{m>724:gz,a<3383:lsk,s<2421:A,fz}\r\njcl{a>3378:A,s<1567:R,A}\r\npm{m<977:R,A}\r\nft{a<3968:R,A}\r\nktp{m<1837:jzs,dxl}\r\nvsj{m>207:R,A}\r\npjg{a<3083:A,s<3749:R,x<491:R,R}\r\nrn{x>3266:A,x<3028:A,s>2454:R,A}\r\nrjj{x<694:lck,R}\r\ncpc{a>3153:R,A}\r\ndf{x>2484:nct,zhf}\r\nfpz{s<129:R,m>1620:A,a<2635:A,A}\r\nqxb{a<1692:mxv,A}\r\nrjb{m<1740:df,s>1900:bmv,m<1912:ktp,th}\r\nfql{a<2531:kl,m<1336:R,m<1729:R,ddj}\r\nmtx{m<574:A,a>3385:R,x>2832:A,A}\r\nbjp{m<302:hzq,x<2687:dqk,vvf}\r\nkjv{a>3075:jsj,a<3004:R,a<3042:A,A}\r\ncr{a>1387:A,s>1535:R,A}\r\nfjm{x<1530:A,x>1775:pbc,x>1626:mfq,A}\r\njcg{x>2441:R,R}\r\nnsq{m>3370:R,m>3177:R,R}\r\nzt{a>1008:gd,zvz}\r\nxs{x>3300:kc,s>754:cg,a<2947:jhr,pz}\r\nfpf{s<3090:cfh,s<3519:bcp,m<934:fh,kt}\r\ngtl{m>2494:A,s<2767:R,s>3241:A,A}\r\ncl{m<658:nzt,R}\r\nbm{s<1419:A,A}\r\nqkm{s<3147:lr,px}\r\njc{a>292:A,R}\r\nlrr{s<2464:R,s>2665:A,R}\r\nsfr{s>1594:A,s<1406:A,A}\r\njss{s<385:cpc,A}\r\ncks{a<3347:A,m>1497:A,m>1438:R,A}\r\nvqb{s<3794:A,A}\r\ntm{m<1090:vd,qm}\r\nxk{m<842:A,m<1321:sp,qd}\r\nzf{a<2394:fcp,a<2554:A,s<2158:A,R}\r\nlrh{s<1419:R,x<652:R,s<1477:A,A}\r\nkcq{a<3825:R,R}\r\nsc{a<2768:R,s>2918:R,s>2526:A,R}\r\nlpk{m>1742:R,R}\r\nlzz{x<3346:A,s>660:R,x<3417:R,R}\r\nfqk{s>1274:R,R}\r\nbgc{a<3564:jcl,kqc}\r\nvh{s<2107:bs,x<2417:xc,lm}\r\nlb{x<1423:A,m<2424:A,m<2603:A,R}\r\ndbp{x<2990:A,R}\r\njf{x<2529:A,m>3833:R,A}\r\nzk{s<2758:hkq,x<2198:tl,hk}\r\nkg{s>3042:R,s<2430:R,R}\r\nzh{a<2554:drk,m<3186:A,hrg}\r\nrj{s>2451:sh,s>2299:jct,kdh}\r\nmxv{m>2171:A,m>1286:R,s<1567:R,R}\r\nnv{x<1693:A,A}\r\nssk{s<1524:A,A}\r\nfgs{m>2627:bdt,ct}\r\nxrc{m<1236:hz,a<2134:jp,s>2439:tqd,R}\r\nkqc{x>611:cmg,s<1534:fvx,gnt}\r\npx{m>2369:A,a>3103:A,hfd}\r\npcd{x<3064:sf,x>3489:qq,brl}\r\nhvc{m<1363:R,m>1409:R,R}\r\nrzc{a>3309:cks,a>3269:lmk,a<3243:A,cjc}\r\nnjd{s<1006:vc,s<1480:mfl,mb}\r\nvc{s>404:xs,mk}\r\nmdp{a<2842:A,x<200:A,x<431:R,A}\r\nnr{a<2936:tc,zpx}\r\nstt{s<3742:A,a<2429:A,A}\r\nbp{s>1625:A,R}\r\njh{x>3726:R,x>3640:A,a>637:R,A}\r\nczg{m>1984:A,A}\r\ngpb{m<443:R,m>754:A,A}\r\nkj{x<843:R,x<942:tsf,A}\r\nrnt{s<858:shr,fsm}\r\npv{m<1137:qb,s<792:nsg,x<1386:A,lpk}\r\nljl{m<2075:vb,R}\r\nvkf{x>836:pl,s<1216:mf,x>426:zd,qxb}\r\nkdx{x<2015:vkf,x<3140:qf,ttv}\r\nhr{s<1980:zr,x>2467:smb,a>3368:dmt,lnx}\r\nsn{m>817:A,x<3461:A,A}\r\nvx{a>1758:A,s<1203:R,s<1355:A,R}\r\nkr{a<2895:A,s<1391:R,A}\r\nccz{s>920:R,R}\r\ntvq{s>734:A,x<1240:R,x<1314:A,A}\r\nqh{x<1010:qsc,x>1431:vvd,a>3080:dqr,cjt}\r\nmc{a<3014:A,R}\r\nmbh{x>3007:A,s<1172:A,s<1552:A,A}\r\nrqp{x>1114:A,m<946:sm,hf}\r\nsz{a<1451:A,A}\r\ngzx{s>3618:pjg,x<579:mdp,szs}\r\nbps{m>1506:R,a>2520:R,A}\r\nfl{x>1717:kn,ltb}\r\ntb{x>3663:R,x>3384:R,R}\r\nzhf{m<1536:bcn,bt}\r\nsf{m>776:nvp,x<2370:zf,bjp}\r\nlfp{s>1251:qzv,jhs}\r\ndxl{m>1885:A,s>771:A,A}\r\nqsc{m>1428:A,m<1232:tbl,x>399:R,A}\r\njjp{a<3653:A,fb}\r\nffg{x<3318:A,s>2102:A,m<1905:R,A}\r\nlrz{x>1539:A,R}\r\njp{s>2644:R,R}\r\nzr{s<1776:vnj,s>1888:R,rgv}\r\nlxp{m>2494:R,m>2241:A,a>3647:A,A}\r\nrqz{a>338:A,A}\r\nfd{x<2753:R,mbh}\r\nhp{a>3707:R,a>3524:A,m>3277:R,R}\r\nvl{m>1659:sc,A}\r\nhnz{m>1381:bfs,s<3698:drc,a>2479:A,A}\r\nnsg{a>843:A,a>744:A,s<406:A,A}\r\nlm{m<2985:fv,xkc}\r\ndff{a>3044:rzk,x<1040:cpv,rxz}\r\nmfl{a>3319:hp,qpn}\r\nzkb{x<2485:R,m>1493:A,R}\r\njl{a>3338:A,m<3078:A,A}\r\ncg{s<841:A,m<3221:A,s>923:R,A}\r\nmq{a>414:A,s<617:R,a>253:R,A}\r\nhf{a>2898:A,R}\r\nxj{x>3177:A,s<1294:nht,m<651:R,R}\r\nzxd{a<2981:A,m>1800:A,x>2930:jx,A}\r\nsmb{m<1780:R,ffg}\r\nqkj{s>2787:cxt,gb}\r\nsp{a<2561:R,m>1156:A,A}\r\nlck{s<1850:R,A}\r\n\r\n{x=302,m=140,a=650,s=1288}\r\n{x=93,m=1448,a=1836,s=292}\r\n{x=3311,m=758,a=62,s=1463}\r\n{x=576,m=1505,a=314,s=1038}\r\n{x=7,m=685,a=4,s=1132}\r\n{x=472,m=57,a=3605,s=9}\r\n{x=2369,m=83,a=412,s=382}\r\n{x=2834,m=573,a=875,s=1127}\r\n{x=97,m=539,a=90,s=1568}\r\n{x=100,m=836,a=263,s=179}\r\n{x=846,m=227,a=396,s=261}\r\n{x=492,m=1517,a=150,s=935}\r\n{x=291,m=3188,a=1419,s=942}\r\n{x=1384,m=1726,a=74,s=1873}\r\n{x=690,m=369,a=115,s=3123}\r\n{x=1399,m=589,a=58,s=135}\r\n{x=512,m=85,a=1572,s=313}\r\n{x=253,m=2433,a=480,s=2736}\r\n{x=2148,m=2367,a=1531,s=96}\r\n{x=1008,m=1373,a=685,s=250}\r\n{x=706,m=815,a=57,s=3476}\r\n{x=236,m=1404,a=652,s=587}\r\n{x=1093,m=2589,a=229,s=329}\r\n{x=656,m=892,a=1729,s=438}\r\n{x=2046,m=2759,a=1544,s=568}\r\n{x=985,m=229,a=2228,s=56}\r\n{x=248,m=1893,a=112,s=609}\r\n{x=2837,m=73,a=1216,s=338}\r\n{x=290,m=44,a=9,s=153}\r\n{x=1499,m=1634,a=2499,s=1240}\r\n{x=2266,m=227,a=1560,s=1034}\r\n{x=32,m=3306,a=744,s=403}\r\n{x=1187,m=171,a=17,s=33}\r\n{x=330,m=259,a=710,s=655}\r\n{x=294,m=325,a=383,s=2483}\r\n{x=2434,m=168,a=1967,s=785}\r\n{x=11,m=586,a=916,s=743}\r\n{x=1773,m=362,a=1553,s=70}\r\n{x=1130,m=1599,a=31,s=622}\r\n{x=1595,m=23,a=1268,s=1578}\r\n{x=3912,m=283,a=1407,s=842}\r\n{x=1081,m=2942,a=807,s=375}\r\n{x=1257,m=1551,a=1523,s=12}\r\n{x=69,m=3109,a=1305,s=2094}\r\n{x=2625,m=1929,a=16,s=759}\r\n{x=926,m=1384,a=629,s=291}\r\n{x=917,m=373,a=740,s=2138}\r\n{x=59,m=1757,a=1283,s=323}\r\n{x=2434,m=510,a=9,s=56}\r\n{x=210,m=395,a=54,s=1646}\r\n{x=3555,m=2225,a=1096,s=120}\r\n{x=462,m=932,a=316,s=13}\r\n{x=177,m=2607,a=570,s=1945}\r\n{x=10,m=3261,a=2065,s=2260}\r\n{x=1017,m=250,a=1022,s=1572}\r\n{x=682,m=169,a=782,s=3}\r\n{x=718,m=483,a=1875,s=1986}\r\n{x=208,m=1563,a=1441,s=1752}\r\n{x=1509,m=1408,a=852,s=1057}\r\n{x=64,m=310,a=1589,s=897}\r\n{x=2427,m=757,a=2034,s=1266}\r\n{x=526,m=45,a=841,s=429}\r\n{x=320,m=778,a=797,s=1253}\r\n{x=65,m=2044,a=354,s=191}\r\n{x=2245,m=163,a=892,s=856}\r\n{x=850,m=321,a=42,s=522}\r\n{x=626,m=410,a=201,s=844}\r\n{x=1130,m=1745,a=1196,s=1984}\r\n{x=89,m=513,a=225,s=1482}\r\n{x=180,m=35,a=198,s=1999}\r\n{x=367,m=1679,a=609,s=127}\r\n{x=32,m=28,a=2507,s=736}\r\n{x=2219,m=1881,a=255,s=199}\r\n{x=635,m=2381,a=2243,s=2395}\r\n{x=1442,m=495,a=2242,s=1557}\r\n{x=863,m=63,a=3459,s=522}\r\n{x=1353,m=493,a=312,s=2}\r\n{x=445,m=401,a=587,s=114}\r\n{x=356,m=2289,a=1520,s=1686}\r\n{x=425,m=568,a=191,s=527}\r\n{x=2595,m=758,a=3569,s=708}\r\n{x=1311,m=2144,a=945,s=771}\r\n{x=167,m=666,a=1899,s=454}\r\n{x=1623,m=281,a=1474,s=579}\r\n{x=102,m=56,a=1720,s=722}\r\n{x=356,m=16,a=602,s=334}\r\n{x=1149,m=212,a=791,s=245}\r\n{x=2357,m=622,a=527,s=220}\r\n{x=1965,m=5,a=1133,s=1332}\r\n{x=1652,m=169,a=21,s=977}\r\n{x=372,m=100,a=674,s=1224}\r\n{x=1774,m=873,a=10,s=221}\r\n{x=8,m=604,a=15,s=201}\r\n{x=779,m=304,a=1486,s=52}\r\n{x=44,m=1797,a=532,s=59}\r\n{x=102,m=1013,a=1916,s=101}\r\n{x=1007,m=621,a=80,s=2917}\r\n{x=825,m=1444,a=845,s=1813}\r\n{x=396,m=55,a=1851,s=570}\r\n{x=2119,m=872,a=1209,s=2087}\r\n{x=1896,m=59,a=2709,s=1492}\r\n{x=680,m=216,a=45,s=1607}\r\n{x=2180,m=2415,a=149,s=793}\r\n{x=955,m=1397,a=616,s=441}\r\n{x=1337,m=746,a=97,s=33}\r\n{x=1291,m=703,a=1680,s=344}\r\n{x=1890,m=50,a=414,s=1292}\r\n{x=207,m=303,a=1959,s=514}\r\n{x=2020,m=1104,a=653,s=3283}\r\n{x=274,m=2059,a=835,s=604}\r\n{x=1945,m=22,a=86,s=711}\r\n{x=1225,m=390,a=1795,s=1384}\r\n{x=1837,m=238,a=638,s=295}\r\n{x=966,m=568,a=2067,s=755}\r\n{x=1942,m=340,a=1419,s=818}\r\n{x=53,m=2013,a=1221,s=1871}\r\n{x=86,m=2633,a=196,s=202}\r\n{x=102,m=2322,a=711,s=3427}\r\n{x=1967,m=477,a=67,s=1255}\r\n{x=2742,m=493,a=1673,s=411}\r\n{x=546,m=252,a=43,s=429}\r\n{x=821,m=422,a=2094,s=1533}\r\n{x=78,m=116,a=184,s=947}\r\n{x=502,m=258,a=1337,s=82}\r\n{x=186,m=372,a=313,s=271}\r\n{x=2717,m=586,a=502,s=342}\r\n{x=490,m=2086,a=45,s=1424}\r\n{x=546,m=1048,a=411,s=663}\r\n{x=1387,m=2721,a=534,s=1500}\r\n{x=22,m=1,a=1231,s=2927}\r\n{x=584,m=1382,a=752,s=1516}\r\n{x=2467,m=1090,a=89,s=2937}\r\n{x=2783,m=126,a=1324,s=801}\r\n{x=1343,m=87,a=2232,s=2066}\r\n{x=846,m=980,a=2807,s=3698}\r\n{x=1260,m=20,a=128,s=199}\r\n{x=26,m=1734,a=53,s=1459}\r\n{x=713,m=1371,a=762,s=827}\r\n{x=1563,m=946,a=539,s=643}\r\n{x=1898,m=3022,a=3464,s=66}\r\n{x=508,m=113,a=2159,s=186}\r\n{x=818,m=1473,a=232,s=11}\r\n{x=140,m=1337,a=2485,s=577}\r\n{x=1196,m=1725,a=857,s=989}\r\n{x=374,m=291,a=276,s=120}\r\n{x=162,m=665,a=660,s=84}\r\n{x=1829,m=590,a=1732,s=551}\r\n{x=55,m=421,a=178,s=349}\r\n{x=51,m=2387,a=235,s=1420}\r\n{x=1795,m=3341,a=624,s=692}\r\n{x=923,m=641,a=3147,s=1686}\r\n{x=62,m=2162,a=953,s=520}\r\n{x=133,m=218,a=3130,s=346}\r\n{x=436,m=291,a=1366,s=1710}\r\n{x=341,m=2054,a=420,s=593}\r\n{x=1451,m=85,a=1296,s=355}\r\n{x=1128,m=372,a=411,s=264}\r\n{x=960,m=477,a=1139,s=444}\r\n{x=2073,m=1841,a=1447,s=734}\r\n{x=1808,m=3556,a=2231,s=80}\r\n{x=1004,m=2097,a=417,s=925}\r\n{x=1593,m=1820,a=1450,s=3391}\r\n{x=576,m=932,a=90,s=742}\r\n{x=295,m=2888,a=2296,s=338}\r\n{x=2693,m=190,a=630,s=1186}\r\n{x=1086,m=66,a=85,s=893}\r\n{x=1181,m=32,a=814,s=88}\r\n{x=1671,m=650,a=933,s=1900}\r\n{x=110,m=682,a=852,s=1431}\r\n{x=141,m=89,a=563,s=2260}\r\n{x=771,m=2014,a=216,s=753}\r\n{x=1485,m=3065,a=2418,s=26}\r\n{x=2175,m=828,a=1241,s=2374}\r\n{x=601,m=785,a=2903,s=707}\r\n{x=2635,m=865,a=1163,s=971}\r\n{x=560,m=2287,a=1469,s=2081}\r\n{x=246,m=4,a=26,s=2596}\r\n{x=1104,m=109,a=788,s=165}\r\n{x=1142,m=2257,a=1125,s=155}\r\n{x=3292,m=2635,a=511,s=744}\r\n{x=2205,m=395,a=197,s=553}\r\n{x=1168,m=1348,a=510,s=238}\r\n{x=1827,m=289,a=359,s=293}\r\n{x=513,m=352,a=1181,s=330}\r\n{x=164,m=2153,a=263,s=408}\r\n{x=363,m=158,a=275,s=2266}\r\n{x=544,m=404,a=2695,s=692}\r\n{x=7,m=730,a=2276,s=32}\r\n{x=988,m=340,a=1480,s=191}\r\n{x=690,m=85,a=1289,s=57}\r\n{x=368,m=813,a=762,s=1787}\r\n{x=2088,m=2053,a=1917,s=2756}\r\n{x=3331,m=712,a=1735,s=309}\r\n{x=334,m=490,a=268,s=1451}\r\n{x=631,m=70,a=371,s=577}\r\n{x=662,m=893,a=541,s=2204}\r\n{x=1147,m=354,a=1121,s=1455}\r\n{x=2517,m=2025,a=2242,s=674}\r\n{x=418,m=1394,a=1326,s=405}\r\n{x=1630,m=354,a=226,s=1078}";

    private class Rule
    {
        public char Character { get; }
        public bool IsGreaterThan { get; }
        public int TestValue { get; }
        public Rule? NextRule { get; }
        public string TruthValue { get; }
        public string? FalseValue { get; }
        public bool HasNextRule => NextRule != null;

        public Rule(string input)
        {
            Character = input[0];
            IsGreaterThan = input[1] == '>';
            var firstColonIndex = input.IndexOf(':');
            var firstCommaIndex = input.IndexOf(",");
            TestValue = int.Parse(input.Substring(2, firstColonIndex - 2));
            TruthValue = input.Substring(firstColonIndex + 1, firstCommaIndex - (firstColonIndex + 1));

            var nextRule = input.Substring(firstCommaIndex + 1);
            if (nextRule.Contains(':'))
            {
                NextRule = new Rule(nextRule);
                FalseValue = null;
            }
            else
            {
                NextRule = null;
                FalseValue = nextRule;
            }
        }

        public string GetNextInput(Dictionary<char, int> inputs)
        {
            if ((IsGreaterThan && TestValue < inputs[Character]) || (!IsGreaterThan && TestValue > inputs[Character]))
            {
                return TruthValue;
            }

            return HasNextRule ? NextRule.GetNextInput(inputs) : FalseValue;
        }
    }

    public void Part1()
    {
        //_input = "px{a<2006:qkq,m>2090:A,rfg}\r\npv{a>1716:R,A}\r\nlnx{m>1548:A,A}\r\nrfg{s<537:gd,x>2440:R,A}\r\nqs{s>3448:A,lnx}\r\nqkq{x<1416:A,crn}\r\ncrn{x>2662:A,R}\r\nin{s<1351:px,qqz}\r\nqqz{s>2770:qs,m<1801:hdj,R}\r\ngd{a>3333:R,R}\r\nhdj{m>838:A,pv}\r\n\r\n{x=787,m=2655,a=1222,s=2876}\r\n{x=1679,m=44,a=2067,s=496}\r\n{x=2036,m=264,a=79,s=2244}\r\n{x=2461,m=1339,a=466,s=291}\r\n{x=2127,m=1623,a=2188,s=1013}";
        long output = 0;
        var a = _input.Split("\r\n\r\n");
        var ruleLines = a[0].Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        var outputLines = a[1].Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        var rules = new Dictionary<string, Rule>();

        for (int i = 0; i < ruleLines.Length; i++)
        {
            var line = ruleLines[i];
            var foo = line.Split(new char[] { '{', '}' });
            var key = foo[0];
            var rule = new Rule(foo[1]);
            rules.Add(key, rule);
        }

        foreach (var line in outputLines)
        {
            var p = line.Split(new char[] { ',', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            var parts = p
                .Select(x => new KeyValuePair<char, int>(x[0], int.Parse(x.Substring(x.IndexOf('=') + 1))))
                .ToDictionary(x => x.Key, x => x.Value);

            var input = "in";

            while (input != "R" && input != "A")
            {
                var rule = rules[input];
                input = rule.GetNextInput(parts);
            }

            if (input == "A")
            {
                var result = parts.Values.Sum();
                output += result;
            }
        }

        Console.WriteLine(output);
    }

    private void UpdateThings(Rule rule, Dictionary<char, int> maxs, Dictionary<char, int> mins)
    {
        if (!rule.HasNextRule && rule.FalseValue == "A" && rule.TruthValue == "A")
        {
            return;
        }

        if (rule.TruthValue == "A")
        {
            var c = rule.Character;

            switch (rule.IsGreaterThan)
            {
                case true:
                    mins[c] = Math.Max(rule.TestValue, mins[c]);
                    break;

                case false:
                    maxs[c] = Math.Min(rule.TestValue, maxs[c]);
                    break;
            }
        }

        if (!rule.HasNextRule && rule.FalseValue == "A")
        {
            var c = rule.Character;

            switch (rule.IsGreaterThan)
            {
                case true:
                    maxs[c] = Math.Min(rule.TestValue, maxs[c]);
                    break;

                case false:
                    mins[c] = Math.Max(rule.TestValue, mins[c]);
                    break;
            }

        }

        if (rule.HasNextRule)
        {
            UpdateThings(rule.NextRule, maxs, mins);
        }
    }

    private void TestPath(Rule rule, Dictionary<string, Rule> rules, Dictionary<char, int> maxs, Dictionary<char, int> mins)
    {
        if(rule.TruthValue == "A")
        {
            var c = rule.Character;

            switch (rule.IsGreaterThan)
            {
                case true:
                    mins[c] = Math.Max(rule.TestValue, mins[c]);
                    break;

                case false:
                    maxs[c] = Math.Min(rule.TestValue, maxs[c]);
                    break;
            }
            // Update condition
        }
        else if(rule.TruthValue != "R")
        {
            TestPath(rules[rule.TruthValue], rules, maxs, mins);
        }

        if (rule.HasNextRule)
        {
            TestPath(rule.NextRule, rules, maxs, mins);
            return;
        }

        if(rule.FalseValue == "A")
        {
            // update condition
            var c = rule.Character;

            switch (rule.IsGreaterThan)
            {
                case true:
                    maxs[c] = Math.Min(rule.TestValue, maxs[c]);
                    break;

                case false:
                    mins[c] = Math.Max(rule.TestValue, mins[c]);
                    break;
            }
        }
        else if(rule.FalseValue != "R")
        {
            TestPath(rules[rule.FalseValue], rules, maxs, mins);
        }
    }

    public void Part2()
    {
        _input = "px{a<2006:qkq,m>2090:A,rfg}\r\npv{a>1716:R,A}\r\nlnx{m>1548:A,A}\r\nrfg{s<537:gd,x>2440:R,A}\r\nqs{s>3448:A,lnx}\r\nqkq{x<1416:A,crn}\r\ncrn{x>2662:A,R}\r\nin{s<1351:px,qqz}\r\nqqz{s>2770:qs,m<1801:hdj,R}\r\ngd{a>3333:R,R}\r\nhdj{m>838:A,pv}\r\n\r\n{x=787,m=2655,a=1222,s=2876}\r\n{x=1679,m=44,a=2067,s=496}\r\n{x=2036,m=264,a=79,s=2244}\r\n{x=2461,m=1339,a=466,s=291}\r\n{x=2127,m=1623,a=2188,s=1013}";

        var a = _input.Split("\r\n\r\n");
        var ruleLines = a[0].Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        var rules = new Dictionary<string, Rule>();

        for (int i = 0; i < ruleLines.Length; i++)
        {
            var line = ruleLines[i];
            var foo = line.Split(new char[] { '{', '}' });
            var key = foo[0];
            var rule = new Rule(foo[1]);
            rules.Add(key, rule);
        }

        var rulesThatAccept = new List<string>();
        var reverseMap = new Dictionary<string, string>();
        var maxs = new Dictionary<char, int> {
            { 'x', 4000},
            { 'm', 4000},
            { 'a', 4000},
            { 's', 4000},
        };
        var mins = new Dictionary<char, int> {
            { 'x', 1},
            { 'm', 1},
            { 'a', 1},
            { 's', 1},
        };

        var input = "in";

        TestPath(rules[input], rules, maxs, mins);
        long output = 1;

        foreach (var (key, max) in maxs)
        {
            var min = mins[key];
            output *= (max - min);
        }

        Console.WriteLine(output);
        //foreach (var (key, rule) in rules)
        //{
        //    if (rule.TruthValue == "A")
        //    {
        //        rulesThatAccept.Add(key);
        //    }
        //    else if (rule.TruthValue != "R")
        //    {
        //        reverseMap.Add(rule.TruthValue, key);
        //    }

        //    if (!rule.HasNextRule)
        //    {
        //        if (rule.FalseValue == "A")
        //        {
        //            rulesThatAccept.Add(key);
        //        }
        //        else if (rule.TruthValue != "R")
        //        {
        //            reverseMap.Add(rule.FalseValue, key);
        //        }
        //    }

        //    var x = rule;
        //    while (x!.HasNextRule)
        //    {
        //        x = x.NextRule;

        //        if (x!.TruthValue == "A")
        //        {
        //            rulesThatAccept.Add(key);
        //        }

        //        else if (x!.TruthValue != "R")
        //        {
        //            reverseMap.Add(x.TruthValue, key);
        //        }

        //        if (x.FalseValue == "A")
        //        {
        //            rulesThatAccept.Add(key);
        //        }
        //        else if (!x.HasNextRule && x.FalseValue != "R")
        //        {
        //            reverseMap.Add(x.FalseValue, key);
        //        }
        //    }
        //}

        //foreach (var id in rulesThatAccept.Distinct())
        //{
        //    var input = id;
        //    while (input != "in")
        //    {
        //        UpdateThings(rules[input], maxs, mins);
        //        input = reverseMap[input];
        //    }
        //}

        //long output = 1;

        //foreach (var (key, max) in maxs)
        //{
        //    var min = mins[key];
        //    output *= (max - min);
        //}
    }

    //private IEnumerable<Dictionary<char, int>> GetPermutations()
    //{
    //    for (var x = 1; x <= 4000; x++)
    //    {
    //        for (var m = 1; m <= 4000; m++)
    //        {
    //            for (var a = 1; a <= 4000; a++)
    //            {
    //                for (var s = 1; s <= 4000; s++)
    //                {
    //                    yield return new Dictionary<char, int>() {
    //                        { 'x', x },
    //                        { 'm', m },
    //                        { 'a', a },
    //                        { 's', s },
    //                    };
    //                }
    //            }
    //        }
    //    }
    //}

    //public void Part2()
    //{
    //    _input = "px{a<2006:qkq,m>2090:A,rfg}\r\npv{a>1716:R,A}\r\nlnx{m>1548:A,A}\r\nrfg{s<537:gd,x>2440:R,A}\r\nqs{s>3448:A,lnx}\r\nqkq{x<1416:A,crn}\r\ncrn{x>2662:A,R}\r\nin{s<1351:px,qqz}\r\nqqz{s>2770:qs,m<1801:hdj,R}\r\ngd{a>3333:R,R}\r\nhdj{m>838:A,pv}\r\n\r\n{x=787,m=2655,a=1222,s=2876}\r\n{x=1679,m=44,a=2067,s=496}\r\n{x=2036,m=264,a=79,s=2244}\r\n{x=2461,m=1339,a=466,s=291}\r\n{x=2127,m=1623,a=2188,s=1013}";
    //    long output = 0;
    //    var a = _input.Split("\r\n\r\n");
    //    var ruleLines = a[0].Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


    //    var rules = new Dictionary<string, Rule>();

    //    for (int i = 0; i < ruleLines.Length; i++)
    //    {
    //        var line = ruleLines[i];
    //        var foo = line.Split(new char[] { '{', '}' });
    //        var key = foo[0];
    //        var rule = new Rule(foo[1]);
    //        rules.Add(key, rule);
    //    }
    //    long acceptableOutputs = 0;
    //    var start = Stopwatch.GetTimestamp();
    //    long index = 0;

    //    Parallel.ForEach(GetPermutations(), parts =>
    //    {
    //        if (index % 1_000_000_000 == 0)
    //        {
    //            Console.WriteLine($"processing row {index} after {Stopwatch.GetElapsedTime(start)}");
    //        }
    //        Interlocked.Increment(ref index);

    //        var input = "in";

    //        while (input != "R" && input != "A")
    //        {
    //            var rule = rules[input];
    //            input = rule.GetNextInput(parts);
    //        }

    //        if (input == "A")
    //        {
    //            Interlocked.Increment(ref acceptableOutputs);
    //            //var result = parts.Values.Sum();
    //            //output += result;
    //        }

    //    });

    //    foreach (var parts in GetPermutations())
    //    {
    //    }

    //    Console.WriteLine(output);
    //}
}