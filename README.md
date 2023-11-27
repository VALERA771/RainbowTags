![Github All Downloads](https://img.shields.io/github/downloads/VALERA771/RainbowTags/total.svg?style=for-the-badge)
<a href="https://github.com/VALERA771/RainbowTags/releases">
  <img src="https://img.shields.io/github/release/VALERA771/RainbowTags/all.svg?style=for-the-badge" alt="GitHub Releases">
</a>

![Build CI](https://github.com/VALERA771/RainbowTags/actions/workflows/build.yml/badge.svg?branch=master)


# RainbowTags
EXILED port of RainbowTags from xNexus-ACS that was a port of [Build](https://github.com/BuildBoy12-SL), [originally](https://github.com/sirmeepington/RainbowTag/) created by [@SirMeepington](https://github.com/sirmeepington). Makes server badges go through a spectrum of colours in SCP:SL. 

This plugin makes use of [EXILED 8](https://github.com/Exiled-Team/EXILED/releases/latest) for [SCP:SL](https://scpslgame.com/)

## Configuration

Default config
```yaml
rainbow_tags:
  is_enabled: true
  debug: false
  # Tags Configuration
  group_sequences:
  - group: 'owner'
    change_time: 0.5
    colors:
    - 'red'
    - 'orange'
    - 'yellow'
    - 'green'
    - 'blue_green'
    - 'magenta'
    - 'silver'
    - 'crimson'
  - group: 'moderator'
    change_time: 0.5
    colors:
    - 'red'
    - 'orange'
    - 'yellow'
    - 'green'
    - 'blue_green'
    - 'magenta'
    - 'silver'
    - 'crimson'
  - group: 'admin'
    change_time: 0.5
    colors:
    - 'red'
    - 'orange'
    - 'yellow'
    - 'green'
    - 'blue_green'
    - 'magenta'
    - 'silver'
    - 'crimson'
```

**Valid Colors**:
* pink
* red
* brown
* silver
* light_green
* crimson
* cyan
* aqua
* deep_pink
* tomato
* yellow
* magenta
* blue_green
* orange
* lime
* green
* emerald
* carmine
* nickel
* mint
* army_green
* pumpkin


#### FAQ

If you get issues about `TAG FAIL`, you've either used a invalid / prohibited color. If you're certain you're not using a prohibited color, remove the color and restart.
change_time minimum time is 0.5.
If you encounter any issues - feel free to ping me at [plugin-bug-reports](https://discord.com/channels/656673194693885975/817074252724699136) on EXILED server or DM me (valera771).
