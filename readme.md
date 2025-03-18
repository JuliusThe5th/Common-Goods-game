# Simulace Hry

Tento program simuluje sázkovou hru, kde pìt hráèù zaèíná s poèáteèní èástkou 10 EUR kadı. Hra probíhá po dobu 10 kol a v kadém kole si hráèi vybírají strategii pro umístìní svıch sázek. Strategie zahrnují férovou hru, sobeckou hru, reaktivní hru a vše na jednu kartu. Poté je bank vynásoben koeficientem a rovnomìrnì rozdìlen mezi hráèe. Cílem je pozorovat, jak rùzné strategie ovlivòují koneèné èástky hráèù.

## Jak spustit

1. Ujistìte se, e máte nainstalovanı .NET 8.
2. Otevøete øešení ve Visual Studio 2022.
3. Sestavte a spuste projekt.

## Strategie

- **Férová hra**: Vsadí polovinu aktuální èástky hráèe.
- **Sobecká hra**: Nesází nic.
- **Reaktivní hra**: Vsadí èástku na základì banku z pøedchozího kola.
- **Vše na jednu kartu**: Vsadí celou èástku hráèe.

### Otázky

#### Funguje to?

Ano, program funguje podle oèekávání. Simuluje sázkovou hru, umoòuje hráèùm vybírat rùzné strategie a aktualizuje jejich èástky po kadém kole.

#### Jak to poznám?

Funkènost programu mùete ovìøit jeho spuštìním a sledováním vıstupu na konzoli. Vıstup zobrazí sázku kadého hráèe, zvolenou strategii, bank pøed a po aplikaci koeficientu a aktualizované èástky hráèù po kadém kole. Konzistentní a logické aktualizace èástek hráèù naznaèují, e program funguje správnì.

### Interpretace

Program ukazuje, jak rùzné sázkové strategie mohou ovlivnit koneèné èástky hráèù bìhem nìkolika kol. Simulací rùznıch strategií poskytuje vhled do úèinnosti jednotlivıch pøístupù v kontrolovaném prostøedí.

### Co jsem si odnesl

Z této simulace jsem se nauèil, e volba strategie vıznamnì ovlivòuje vısledek ve sázkové høe. Strategie jako "Vše na jednu kartu" mohou vést k vysokım odmìnám, ale také k vysokım rizikùm, zatímco "Sobecká hra" zajišuje stabilitu, ale nemusí pøinést vıznamné zisky. Program efektivnì ilustruje dùleitost strategického rozhodování ve hrách náhody.

### Analıza po nìkolika kolech

#### Jak se vyvíjí celkovı fond (zda roste nebo klesá)

Celkovı fond má tendenci rùst díky koeficientu, kterı se aplikuje na bank po kadém kole. Tento rùst je však závislı na sázkách hráèù a jejich strategiích.

#### Zda férové strategie pøeijí, nebo zda se vìtšina hráèù uchılí ke free-ridingu

Férové strategie mohou pøeít, pokud jsou hráèi ochotni riskovat a sázet polovinu svıch prostøedkù. Nicménì, sobecké strategie (free-riding) mohou bıt preferovány hráèi, kteøí chtìjí minimalizovat riziko a udret své prostøedky.

#### Jaké strategie jsou nejvıhodnìjší z dlouhodobého hlediska

Z dlouhodobého hlediska se ukazuje, e strategie "Vše na jednu kartu" mùe vést k vysokım ziskùm, ale také k vysokım rizikùm. Strategie "Sobecká hra" zajišuje stabilitu, ale nemusí pøinést vıznamné zisky. "Reaktivní hra" a "Férová hra" mohou bıt vıhodné, pokud jsou správnì naèasovány a pøizpùsobeny situaci v kadém kole.
