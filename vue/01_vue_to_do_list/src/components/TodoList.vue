<script lang="ts" setup>
import ListItem from './ListItem.vue'
type Item = {
  title: string
  checked: boolean
}
const listItems: Item[] = [
  { title: 'Make a todo list app', checked: true },
  { title: 'Predict the weather', checked: false },
  { title: 'Play some tunes', checked: false },
  { title: "Let's get cooking", checked: false },
  { title: 'Pump some iron', checked: false },
  { title: 'Track my expenses', checked: false },
  { title: 'Organize a game night', checked: false },
  { title: 'Learn a new language', checked: false },
  { title: 'Publish my work', checked: false },
]
</script>
<template>
  <ul>
    <!-- <ListItem :is-checked="false">This is the slotted content</ListItem> -->
    <li :key="key" v-for="(item, key) in listItems">
      <ListItem :is-checked="item.checked"> {{ item.title }}</ListItem>
    </li>
  </ul>
</template>
