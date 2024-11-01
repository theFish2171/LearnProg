<script lang="ts" setup>
import ListItem from "./ListItem.vue";
import { ref, computed, onMounted } from "vue";
import type { Ref } from "vue";

type Item = {
  title: string;
  checked?: boolean;
};

const storageItems: Ref<Item[]> = ref([]);
onMounted(() => {
  storageItems.value = getFromStorage();
  initListItem();
});

const sortedList = computed(() =>
  [...storageItems.value].sort(
    (a, b) => (a.checked ? 1 : 0) - (b.checked ? 1 : 0)
  )
);

const updateItem = (item: Item): void => {
  const updatedItem = findItemInList(item);
  if (updatedItem) {
    toggleItemChecked(updatedItem);
    setToStorage(storageItems.value);
  }
};

const findItemInList = (item: Item): Item | undefined => {
  return storageItems.value.find(
    (itemInList: Item) => itemInList.title === item.title
  );
};

const toggleItemChecked = (item: Item): void => {
  item.checked = !item.checked;
};

const setToStorage = (items: Item[]): void => {
  console.log(`setting to storage`);
  localStorage.setItem("list-items", JSON.stringify(items));
};

const getFromStorage = (): Item[] | [] => {
  console.log(`getting from storage`);
  const stored = localStorage.getItem("list-items");
  console.log("got " + stored?.length);

  if (stored) {
    return JSON.parse(stored);
  }
  return [];
};

const initListItem = (): void => {
  if (storageItems.value?.length === 0) {
    const listItems: Item[] = [
      { title: "Make a todo list app", checked: true },
      { title: "Predict the weather", checked: false },
      { title: "Play some tunes", checked: false },
      { title: "Let's get cooking", checked: false },
      { title: "Pump some iron", checked: false },
      { title: "Track my expenses", checked: false },
      { title: "Organize a game night", checked: false },
      { title: "Learn a new language", checked: false },
      { title: "Publish my work" },
    ];
    setToStorage(listItems);
    storageItems.value = listItems;
  }
};
</script>

<template>
  <ul>
    <li :key="key" v-for="(item, key) in sortedList">
      <ListItem
        :is-checked="item.checked"
        v-on:click.prevent="updateItem(item)"
      >
        {{ item.title }}
      </ListItem>
    </li>
  </ul>
</template>

<!-- Code from the book -->
<!-- <template>
  <ul>
    <li :key="key" v-for="(item, key) in listItems">
      <ListItem :is-checked="item.checked">{{ item.title }}</ListItem>
    </li>
  </ul>
</template> -->

<style scoped>
ul {
  list-style: none;
}
li {
  margin: 0.4rem 0;
}
</style>
