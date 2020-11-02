# HousingEstate

Naprogramujte systém pre sídliská, v ktorom bude možné evidovať obyvateľov žijúcich na danom sídlisku. Do jednotlivých bytov sídliska sa budú môcť ľudia nasťahovať, presťahovať do iného bytu alebo úplne opustiť sídlisko. Pre každý vchod nám bude systém schopný poskytnúť údaje o najstaršom a najmladšom obyvateľovi, a tiež vekový priemer všetkých obyvateľov vchodu. To isté sa bude dať pre celý panelák a sídlisko. So systémom sa bude dať pracovať pomocou konzoly vďaka menu – napríklad keď používateľ zadá 1 bude môcť pridať obyvateľa do nejakého bytu atď. Pre source control použite git. Toto repository nemusíte forkovať. Vytvorte si vlasné.

## Class Person
Reprezentuje človeka, ktorý je obyvateľom bytu. Každá osoba je charakterizovaná menom, priezviskom a vekom. Každá osoba prináleží nejakému bytu, preto si každá osoba uchováva referenciu na byt, v ktorom býva.

## Class Flat
Reprezentuje byt. Každý byt je označený číslom bytu (číslujeme od 1 hore) a musí sa nachádzať v nejakom vchode. V byte bývajú osoby, preto je nutné uchovávať zoznam týchto osôb.

## Class  Entrance
Reprezentuje vchod. Každý vchod je označený orientačným číslom, pričom orientačné čísla susedných vchodov sa líšia o 2. Na jednej strane ulice sa zvyknú používať párne čísla a na opačnej strane zasa nepárne. Každý vchod má niekoľko poschodí, na ktorých je istý počet bytov. Okrem toho si každý vchod pamätá, do ktorého paneláku patrí.

## Class BlockOfFlats
Reprezentuje panelák. Každý panelák je označený súpisným číslom a skladá sa z niekoľkých vchodov. Každý panelák sa nachádza na konkrétnej ulici.

## Class HousingEstate
Reprezentuje celé sídlisko, ktoré sa skladá z množiny panelákov.


### Dodatočné info
V testovacom príklade pracujte s nasledujúcimi hodnotami:
Počet vchodov paneláku: 12
Počet bytov vchodu: 14 (7 poschodí, na každom 2 byty)
Kapacita bytov: 4

Čo nie je jasné, to si domyslite tak, aby to dávalo zmysel. Čo si nebudete vedieť domyslieť, pýtajte sa.
