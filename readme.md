# Azure functions -> TimerTrigger og HttpTrigger- C<span>#</span>

# Hvordan kalle på HttpTrigger

## Alle HttpTrigger henter informasjon fra Brønnøysundregistrene.

- Hent informasjon om Sopra Steria<br/>
  https://crigertest.azurewebsites.net/api/getSopraSteria
  
- Hent informasjon om et gitt selskap, via organisasjonsnummer<br/>
  https://crigertest.azurewebsites.net/api/organization?orgId=FYLL_INN_ORGANISASJONSNUMMER_HER

- Hent en liste over selskaper som matcher det man søker etter, dvs selskapsnavn<br/>
  https://crigertest.azurewebsites.net/api/getByName?name=FYLL_INN_SELSKAPSNAVN_HER

## Men TimerTrigger da??
Denne kjører etter gitte intervaller som er bestemt i Environments seksjonen for Functions i Azure.
Som standard er denne satt til ___55 11 * 2 4 *___
Dette oversettes til: kl 11:55, torsdager i måned 2 (dvs februar)

Timer trigger kjøres i Azure og man må derfor se loggen i Azure for å kunne se at denne kjører.

## Trenger du mer informasjon?
Ta kontakt med utvikler Cristhian Gertner, mobil: 916 38 222
