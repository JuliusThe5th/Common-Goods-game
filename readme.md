# Simulace Hry

Tento program simuluje s�zkovou hru, kde p�t hr��� za��n� s po��te�n� ��stkou 10 EUR ka�d�. Hra prob�h� po dobu 10 kol a v ka�d�m kole si hr��i vyb�raj� strategii pro um�st�n� sv�ch s�zek. Strategie zahrnuj� f�rovou hru, sobeckou hru, reaktivn� hru a v�e na jednu kartu. Pot� je bank vyn�soben koeficientem a rovnom�rn� rozd�len mezi hr��e. C�lem je pozorovat, jak r�zn� strategie ovliv�uj� kone�n� ��stky hr���.

## Jak spustit

1. Ujist�te se, �e m�te nainstalovan� .NET 8.
2. Otev�ete �e�en� ve Visual Studio 2022.
3. Sestavte a spus�te projekt.

## Strategie

- **F�rov� hra**: Vsad� polovinu aktu�ln� ��stky hr��e.
- **Sobeck� hra**: Nes�z� nic.
- **Reaktivn� hra**: Vsad� ��stku na z�klad� banku z p�edchoz�ho kola.
- **V�e na jednu kartu**: Vsad� celou ��stku hr��e.

### Ot�zky

#### Funguje to?

Ano, program funguje podle o�ek�v�n�. Simuluje s�zkovou hru, umo��uje hr���m vyb�rat r�zn� strategie a aktualizuje jejich ��stky po ka�d�m kole.

#### Jak to pozn�m?

Funk�nost programu m��ete ov��it jeho spu�t�n�m a sledov�n�m v�stupu na konzoli. V�stup zobraz� s�zku ka�d�ho hr��e, zvolenou strategii, bank p�ed a po aplikaci koeficientu a aktualizovan� ��stky hr��� po ka�d�m kole. Konzistentn� a logick� aktualizace ��stek hr��� nazna�uj�, �e program funguje spr�vn�.

### Interpretace

Program ukazuje, jak r�zn� s�zkov� strategie mohou ovlivnit kone�n� ��stky hr��� b�hem n�kolika kol. Simulac� r�zn�ch strategi� poskytuje vhled do ��innosti jednotliv�ch p��stup� v kontrolovan�m prost�ed�.

### Co jsem si odnesl

Z t�to simulace jsem se nau�il, �e volba strategie v�znamn� ovliv�uje v�sledek ve s�zkov� h�e. Strategie jako "V�e na jednu kartu" mohou v�st k vysok�m odm�n�m, ale tak� k vysok�m rizik�m, zat�mco "Sobeck� hra" zaji��uje stabilitu, ale nemus� p�in�st v�znamn� zisky. Program efektivn� ilustruje d�le�itost strategick�ho rozhodov�n� ve hr�ch n�hody.
